using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies
{
    //Razor 页面派生自 PageModel。 按照约定，PageModel 派生的类称为 <PageName>Model。 此构造函数使用依赖关系注入将 RazorPagesMovieContext 添加到页。 所有已搭建基架的页面都遵循此模式。 请参阅异步代码，了解有关使用实体框架的异步编程的详细信息。
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesMovieContext _context;

        public IndexModel(RazorPagesMovie.Data.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        //对页面发出请求时，OnGetAsync 方法向 Razor 页面返回影片列表。 调用 OnGetAsync 或 OnGet 以初始化页面的状态。 在这种情况下，OnGetAsync 将获得影片列表并显示出来。
        //当 OnGet 返回 void 或 OnGetAsync 返回 Task 时，不使用任何返回语句。 当返回类型是 IActionResult 或 Task<IActionResult> 时，必须提供返回语句。 例如，Pages/Movies/Create.cshtml.cs OnPostAsync 方法：
        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
        
       /* public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

        //Movie报错

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
       */
    }
}
