using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BankApi.Models.Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        public string UserEmail { get; set; }
        [Required]
        public string Password { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public IEnumerable<Account> Accounts { get; set; }
    }
}
