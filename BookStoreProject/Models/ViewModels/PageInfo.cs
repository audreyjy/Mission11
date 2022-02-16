using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models.ViewModels
{
    public class PageInfo
    { 
        public int TotalNumBooks { get; set; } // keeps track of how many projects there are 
        public int BooksPerPage { get; set; }// keeps track of how many projects we're going to show on page
        public int CurrentPage { get; set; } // keeps track of what page I'm on 
        public int TotalPages => (int) Math.Ceiling((double) TotalNumBooks / BooksPerPage); // determine how many pages we need. cast totalnumporjects as a double, then cast the calculation to double, then force it to integer 
    }
}
