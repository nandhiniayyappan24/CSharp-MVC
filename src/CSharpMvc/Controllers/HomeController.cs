using Microsoft.AspNetCore.Mvc;
using CSharpMvc.Models;
using CSharpMvc.Services;

namespace CSharpMvc.Controllers
{
    [Route("[controller]")]
    public sealed class HomeController : Controller
    {
        private readonly IOrderService _orderService;

        public HomeController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpGet("")]
        [HttpGet("Index")]
        public IActionResult Index()
        {
            ViewData["Message"] = _orderService.GetWelcomeMessage();
            return View(new HomeViewModel { Title = "CSharp MVC", Framework = "net7.0" });
        }

        [HttpGet("Privacy")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [HttpGet("Error")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = HttpContext.TraceIdentifier });
        }
    }
}
