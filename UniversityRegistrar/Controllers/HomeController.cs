using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;


namespace UniversityRegistrar.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();ß
    }

    public IActionResult Privacy()
    {
        return View();
    }
}
