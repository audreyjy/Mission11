using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    public interface iBookStoreRepository
    {
        IQueryable<Books> Books { get; } // put in the model name followed by 
    }
}
