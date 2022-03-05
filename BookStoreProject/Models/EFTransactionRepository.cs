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
            context = temp; 
        }
        public IQueryable<Transaction> Transaction => context.Transactions.Include(x => x.Lines).ThenInclude(x => x.Books);

        public void SaveTransaction(Transaction transaction)
        {
            context.AttachRange(transaction.Lines.Select(x => x.Books)); 

            if (transaction.TransactionId == 0)
            {
                context.Transactions.Add(transaction);
            }

            context.SaveChanges(); 
        }
    }
}
