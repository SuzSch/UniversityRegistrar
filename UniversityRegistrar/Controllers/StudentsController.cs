using Microsoft.AspNetCore.Mvc;
using UniversityRegistrar.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace UniversityRegistrar.Controllers
{
    public class UniversityRegistrarController : Controller
    {
        private readonly UniversityRegistrarContext _db;
        public UniversityRegistrarController (UniversityRegistrarContext db)
        {
            _db = db;
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}