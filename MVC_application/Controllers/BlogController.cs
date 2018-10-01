﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVC_application.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MVC_application.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        // GET: /<controller>/
        [Route("")]
        public IActionResult Index()
        {
            var posts = new[]
            {
                new Post_Model
                {
                    Title = "my first blog post",
                    Posted = DateTime.Now,
                    Author = "some guy",
                    Body = "this is some guy's post about shit"
                },
                new Post_Model
                {
                    Title = "my second blog post",
                    Posted = DateTime.Now,
                    Author = "some guy",
                    Body = "this is some guy's post about shit"
                },
                new Post_Model
                {
                    Title = "my thrid blog post",
                    Posted = DateTime.Now,
                    Author = "some guy",
                    Body = "this is some guy's post about shit"
                }
            };
            return View(posts);
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = new Post_Model {
                Title = "my blog post",
                Posted = DateTime.Now,
                Author = "some guy",
                Body = "this is some guy's post about shit"
            };
            return View(post);

        }
         
    
       
    }
}