using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    public class EFTransactionRepository : ITransactionRepository
    {
        private BookstoreContext context; 

        public EFTransactionRepository (BookstoreContext temp)
        {

        }
        public IQueryable<Transaction> Transaction => context.Transactions.Include(x => x.Lines).ThenInclude(x => x.Book);

        public void SaveTransaction(Transaction transaction)
        {
            
        }
    }
}
