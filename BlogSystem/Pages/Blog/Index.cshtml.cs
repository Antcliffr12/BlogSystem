using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSystem.Data;
using BlogSystem.Model;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BlogSystem.Pages.Blog
{
    public class IndexModel : PageModel
    {
        private readonly BlogDataContext _db;

        public IndexModel(BlogDataContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Blogs Blog { get; set; }


        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                Blog.Author = User.Identity.Name;
                Blog.Posted = DateTime.Now;
                await _db.Blog.AddAsync(Blog);
                await _db.SaveChangesAsync();
                return RedirectToPage("BlogPage", "OnGetAsync", new
                {
                    year = Blog.Posted.Year,
                    month = Blog.Posted.Month,
                    key = Blog.Title,
                    id = Blog.Id
                });

            }
            else
            {
                return Page();
            }
        }
    }
}
