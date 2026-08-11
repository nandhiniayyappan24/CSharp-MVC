using Microsoft.AspNetCore.Mvc;
using CSharpMvc.Models;
using CSharpMvc.Services;

namespace CSharpMvc.Controllers;

[Route("[controller]")]
public sealed class HomeController(IOrderService orderService) : Controller
{
    [HttpGet("")]
    [HttpGet("Index")]
    public IActionResult Index()
    {
        ViewData["Message"] = orderService.GetWelcomeMessage();
        return View(new HomeViewModel { Title = "CSharp MVC", Framework = "net8" });
    }

    [HttpGet("Privacy")]
    public IActionResult Privacy() => View();

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    [HttpGet("Error")]
    public IActionResult Error() =>
        View(new ErrorViewModel { RequestId = HttpContext.TraceIdentifier });
}
