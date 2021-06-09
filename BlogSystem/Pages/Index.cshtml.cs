using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Data;
using BlogSystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace BlogSystem.Pages
{
    public class IndexModel : PageModel
    {
        private readonly BlogDataContext _db;

        public IndexModel(BlogDataContext db)
        {
            _db = db;
        }

        public IEnumerable<Blogs> Blog { get; set; }


        public async Task OnGet(int page = 0)
        {           
            Blog = await _db.Blog.OrderByDescending(x => x.Posted).Take(5).ToArrayAsync();
        }
    }
}
