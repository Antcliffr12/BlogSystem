using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using BlogSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace BlogSystem.Pages.Blog
{
    public class BlogPageModel : PageModel
    {

        private readonly BlogDataContext _db;

        public BlogPageModel(BlogDataContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Blogs Blog { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            //Find Blog Id from URL
            Blog = await _db.Blog.FirstOrDefaultAsync(b => b.Id == id);
            if(Blog == null)
            {
                return NotFound();
            }

            return Page();
       
        }

        private bool BlogExist(int id)
        {
            return _db.Blog.Any(e => e.Id == id);
        }


    }
}
