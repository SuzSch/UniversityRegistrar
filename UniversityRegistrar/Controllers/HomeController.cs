using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;


namespace UniversityRegistrar.Controllers;

public class HomeController : Controller
{
    public ActionResult Index()
    {
        return View();
    }
}
