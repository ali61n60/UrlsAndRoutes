using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UrlAndRoutes.Models;

namespace UrlsAndRoutes.Controllers
{
    public class HomeController:Controller
    {
        public ViewResult Index()
        {
            Result result = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(Index)
            };
            return View("Result",result);
        }
    }
}
