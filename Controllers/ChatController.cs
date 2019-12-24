using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebChat.Models;

namespace WebChat.ChatController
{
    [ApiController]
    [Route("[controller]")]
    public class ChatController : ControllerBase
    {
        private static readonly string[] MessageList = new[]
        {
            "A", "B", "C", "D", "E"
        };

        [HttpGet]
        public IEnumerable<Chat> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Chat
            {
                ID = rng.Next(-20, 55),
                Date = DateTime.Now.AddDays(index),
                Message = MessageList[rng.Next(MessageList.Length)]
            })
            .ToArray();
        }
    }
}
