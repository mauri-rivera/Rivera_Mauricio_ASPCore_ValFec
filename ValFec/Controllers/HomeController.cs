using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ValFec.Models;

namespace ValFec.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet("")]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost("")]
    public IActionResult Index(Fecha fecha)
    {
        if (ModelState.IsValid)
        {
            return RedirectToAction("Index", fecha);
        }
        else
        {
            return View("Index", fecha);
        }
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
