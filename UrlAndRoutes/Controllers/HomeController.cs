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
        public ViewResult Index(string id)
        {
            Result result = new Result
            {
                Controller = nameof(HomeController)
                ,
                Action = nameof(Index)
            };
            return View("Result",result);
        }

        public ViewResult CustomVariable()
        {
            Result r = new Result
            {
                Controller = nameof(HomeController),
                Action = nameof(CustomVariable),
            };
            r.Data["id"] = RouteData.Values["id"];
            return View("Result", r);
        }
    }
}
