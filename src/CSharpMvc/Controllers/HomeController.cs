using System.Web.Mvc;
using CSharpMvc.Models;
using CSharpMvc.Services;

namespace CSharpMvc.Controllers
{
    public sealed class HomeController : Controller
    {
        private readonly OrderService _orderService = new OrderService();

        public ActionResult Index()
        {
            ViewData["Message"] = _orderService.GetWelcomeMessage();
            return View(new HomeViewModel { Title = "CSharp MVC", Framework = "net4.5" });
        }

        public ActionResult Privacy()
        {
            return View();
        }
    }
}
