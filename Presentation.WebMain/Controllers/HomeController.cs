using Business.Serveices;
using Data.BaseRepository;
using Data.Entity.Models;
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
         public IActionResult Index()
        {
          var baseServeices = new  BaseServeices();
            return View(baseServeices.GetTeams());
        }
    }
}
