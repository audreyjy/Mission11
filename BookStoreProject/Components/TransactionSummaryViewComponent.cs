using BookStoreProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Components
{
    public class TransactionSummaryViewComponent : ViewComponent
    {
        private Basket basket; 

        public TransactionSummaryViewComponent(Basket basketService)
        {
            basket = basketService; 
        }

        public IViewComponentResult Invoke ()
        {
            return View(basket); 
        }
            


    }
}
