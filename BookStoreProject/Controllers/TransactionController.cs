using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreProject.Models; 

namespace BookStoreProject.Controllers
{
    public class TransactionController : Controller
    {
        public TransactionController ()
        {

        }

        [HttpGet]
        public IActionResult Checkout()
        {
            return View(new Transaction());
        }

        [HttpPost]
        public IActionResult Checkout(Transaction transaction)
        {
            //
        }
    }
}
