using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookStoreProject.Models; 

namespace BookStoreProject.Models.Components
{
    public class CategoriesViewComponent : ViewComponent
    {
        // get data for component
        private iBookStoreRepository repo { get; set; }

        public CategoriesViewComponent (iBookStoreRepository temp)
        {
            repo = temp; 
        }

        // invoke method 
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData.Values["bookCategory"];

            // get category types 
            var categories = repo.Books
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x);

            return View(categories); 
        }
    }
}


