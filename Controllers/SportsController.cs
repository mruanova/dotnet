/*
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
    public class SportsController : Controller
    {
        private readonly ILogger<SportsController> _logger;
        private MauContext dbContext;
        public SportsController(ILogger<SportsController> logger, MauContext context)
        {
            _logger = logger;
            dbContext = context;
        }

        [HttpGet("messages")]
        public IActionResult Index()
        {
            List<Sports> messagesWithUser = dbContext.Sports
            // populates each Sports with its related User object (Creator)
            .Include(message => message.Creator)
            .ToList();

            return View(messagesWithUser);
        }
    }
}
*/