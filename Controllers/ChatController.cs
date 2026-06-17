using Microsoft.AspNetCore.Mvc;
using OfflineAIChat.Services;

namespace OfflineAIChat.Controllers
{
    public class ChatController : Controller
    {
        private readonly AIService _aiService;

        public ChatController(AIService aiService)
        {
            _aiService = aiService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Ask(string prompt)
        {
            var response = await _aiService.AskAI(prompt);

            ViewBag.Response = response;

            return View("Index");
        }
    }
}