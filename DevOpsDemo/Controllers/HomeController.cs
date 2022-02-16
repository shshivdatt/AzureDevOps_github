﻿using DevOpsDemo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DevOpsDemo.Repository;
namespace DevOpsDemo.Controllers
{
    public class HomeController : Controller
    {
        IPostRepository postRepository;
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger, IPostRepository _postRepository)
        {
            _logger = logger;
            postRepository = _postRepository;
        }

        public IActionResult Index()
        {
            var model = postRepository.GetPosts();
            return View(model);
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
}
