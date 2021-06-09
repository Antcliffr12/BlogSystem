using System;
using System.Linq;
using BlogSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace BlogSystem.Data
{
    public class BlogDataContext : DbContext
    {
        public BlogDataContext(DbContextOptions<BlogDataContext> options) : base(options)
        {

        }

        public DbSet<Blogs> Blog { get; set; }

    }
}

