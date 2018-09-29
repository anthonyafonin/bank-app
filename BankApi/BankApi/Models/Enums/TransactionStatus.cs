using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models.Enums
{
    public enum TransactionStatus
    {
        Created = 1,
        Posted = 2,
        Cancelled = 3,
        Rejected = 4
    }
}
