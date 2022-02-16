using BookStoreProject.Models;
using BookStoreProject.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Controllers
{
    public class HomeController : Controller
    {
        private iBookStoreRepository repo; 
        public HomeController (iBookStoreRepository temp)
        {
            repo = temp; ; 
        }
        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 10; // 10 records per page

            var x = new BooksViewModel
            {
                Books = repo.Books
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = repo.Books.Count(),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            }; 

            return View(x);
        }
    }
}
