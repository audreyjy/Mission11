using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    public interface iBookStoreRepository
    {
        IQueryable<Books> Books { get; } // put in the model name followed by 

        public void SaveBook(Books b);
        public void CreateBook(Books b);
        public void DeleteBook(Books b); 
    }
}
