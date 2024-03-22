using Microsoft.AspNetCore.Mvc;
using Mission11_Nieves.Models;
using System.Diagnostics;
using Mission11_Nieves.Models.ViewModels;

namespace Mission11_Nieves.Controllers
{
    public class HomeController : Controller
    {
        private IBooksRepository _repo;

        public HomeController(IBooksRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            var list = new BooksListViewModel
            {
                Books = _repo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _repo.Books.Count()
                }
            };

            return View(list);
        }
    }
}
