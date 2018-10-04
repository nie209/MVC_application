using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_application.Models
{
    public class BlogdbContext :DbContext
    {
        public DbSet<Post_Model> Posts { get; set; }
        public BlogdbContext(DbContextOptions<BlogdbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
