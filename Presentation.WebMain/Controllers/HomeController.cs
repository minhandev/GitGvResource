using Data.BaseRepository;
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
        private readonly IUnitOfWork<Employee> unitOfWork;

        public HomeController(IUnitOfWork<Employee> unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            var list = await unitOfWork.Repository.All();
            return View(list);
        }
    }
}
