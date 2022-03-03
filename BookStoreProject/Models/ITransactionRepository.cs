using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreProject.Models
{
    public interface ITransactionRepository
    {
        IQueryable<Transaction> Transaction { get; }

        void SaveTransaction(Transaction transaction); 
    }
}
