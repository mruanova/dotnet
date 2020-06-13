using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
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

            return View();
        }
    }
}