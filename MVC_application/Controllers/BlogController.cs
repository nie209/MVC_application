using System;
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
        private readonly BlogdbContext _db;
        public BlogController(BlogdbContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        [Route("")]
        public IActionResult Index()
        {
            var posts = _db.Posts.OrderByDescending(x => x.Posted).Take(5).ToArray(); // taking infomation out of the local database
            return View(posts);
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var post = _db.Posts.FirstOrDefault(x => x.Key == key);
            return View(post);

        }
        
        [Route("Create")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost, Route("Create")] 
        public IActionResult Create(Post_Model post)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }
            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;
            _db.Add(post);
            _db.SaveChanges();
            return RedirectToAction("Post", "Blog", new
            {
                year = post.Posted.Year,
                month = post.Posted.Month,
                key = post.Key
            });
        }

    }
}
