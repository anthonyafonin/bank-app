using BankApi.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models.Entities
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        [Required]
        public User User { get; set; }
        [Required]
        public AccountType AccountType { get; set; }
        public DateTime DateCreated { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }

    }
}
