using Data.BaseRepository;
using Data.Entity;
using Data.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Presentation.WebMain.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Presentation.WebMain.Controllers
{
    public class HomeController : Controller
    {
         public async Task<IActionResult> Index()
        {
            using(var context = new GvResourceContext())
            {
                var unit = new UnitOfWork(context);
                var list = await unit.Employee.All();
                return View(list);
            }
        }
    }
}
