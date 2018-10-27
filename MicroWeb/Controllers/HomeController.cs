﻿using Dapper.Extension;
using Dapper.Extension.Model;
using MicroWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MicroWeb.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(RequestMemberModel req)
        {
            var service = ServiceContainer.Resolve<Service>();
            service.CreateOrder(req);
            return View();
        }
    }
}