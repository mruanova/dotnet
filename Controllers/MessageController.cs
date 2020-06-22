using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MauDotNetCore.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace MauDotNetCore.Controllers
{
    public class MessageController : Controller
    {
        private readonly ILogger<MessageController> _logger;
        private MauContext dbContext;
        public MessageController(ILogger<MessageController> logger, MauContext context)
        {
            _logger = logger;
            dbContext = context;
        }

        [HttpGet("messages")]
        public IActionResult Index()
        {
            Thread.CurrentThread.Name = "Main";
            // Create a task and supply a user delegate by using a lambda expression.
            Task taskA = new Task(() => Console.WriteLine("Hello from taskA."));
            // Start the task.
            taskA.Start();
            // Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.", Thread.CurrentThread.Name);
            taskA.Wait();

            Task taskB = Task.Run(() => Console.WriteLine("Hello from taskB."));
            // Output a message from the calling thread.
            Console.WriteLine("Hello from thread '{0}'.", Thread.CurrentThread.Name);
            taskB.Wait();

            Task[] taskArray = new Task[10];
            for (int i = 0; i < taskArray.Length; i++)
            {
                taskArray[i] = Task.Factory.StartNew((Object obj) =>
                {
                    CustomData data = obj as CustomData;
                    if (data == null)
                        return;

                    data.ThreadNum = Thread.CurrentThread.ManagedThreadId;
                }, new CustomData() { Name = i, CreationTime = DateTime.Now.Ticks });
            }
            Task.WaitAll(taskArray);
            foreach (var task in taskArray)
            {
                var data = task.AsyncState as CustomData;
                if (data != null)
                    Console.WriteLine("Task #{0} created at {1}, ran on thread #{2}.", data.Name, data.CreationTime, data.ThreadNum);
            }

            /*
            Hello from thread 'Main'.
            Hello from taskA.
            Hello from thread 'Main'.
            Hello from taskB.
            Task #0 created at 637284356079654260, ran on thread #29.
            Task #1 created at 637284356080115210, ran on thread #30.
            Task #2 created at 637284356080115400, ran on thread #26.
            Task #3 created at 637284356080116820, ran on thread #31.
            Task #4 created at 637284356080119370, ran on thread #32.
            Task #5 created at 637284356080119430, ran on thread #32.
            Task #6 created at 637284356080119450, ran on thread #32.
            Task #7 created at 637284356080119460, ran on thread #34.
            Task #8 created at 637284356080119470, ran on thread #33.
            Task #9 created at 637284356080119480, ran on thread #33.
            */

            List<Message> messagesWithUser = dbContext.Messages
            // populates each Message with its related User object (Creator)
            .Include(message => message.Creator)
            .ToList();

            return View(messagesWithUser);
        }

        [HttpGet("{userId}")]
        public IActionResult UserDetails(int userId)
        {
            // Number of messages created by this User
            int numMessages = dbContext.Users
                // Including Messages, so that we may query on this field
                .Include(user => user.CreatedMessages)
                // Get a User with userId
                .FirstOrDefault(user => user.UserId == userId)
                // Now, with a reference to a User object, and access to a User's Messages
                // We can get the .Count property of the Messages List
                .CreatedMessages.Count;

            // User with the longest Message, we can do this in two stages

            // First, find the Length of the longest Message
            int longestMessageLength = dbContext.Messages.Max(message => message.Content.Length);

            // Second, select one User who's CreatedMessages has Any that matches this character count
            // Note here that CreatedMessages is a List, and thus can take a LINQ expression: such as .Any()
            User userWithLongest = dbContext.Users
                .Include(user => user.CreatedMessages)
                .FirstOrDefault(user => user.CreatedMessages
                    .Any(message => message.Content.Length == longestMessageLength));

            // Messages NOT related to this User:
            // Since this query only requires checking a Message's UserId
            // and doesn't require us to check data contained in a Message's Creator
            // We can do this without a .Include()
            List<Message> unrelatedMessages = dbContext.Messages
                .Where(message => message.UserId != userId)
                .ToList();

            User userDetails = dbContext.Users
                // Get a User with userId
                .FirstOrDefault(user => user.UserId == userId);

            return View(userDetails);
        }
    }
}