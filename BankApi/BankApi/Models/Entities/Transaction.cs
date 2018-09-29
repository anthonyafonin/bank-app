using BankApi.Models.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace BankApi.Models.Entities
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }
        [Required]
        public string Transactor { get; set; }
        public string Description { get; set; }
        [Required]
        public TransactionType TransactionType { get; set; }
        [Required]
        public TransactionStatus TransactionStatus { get; set; }
        [Required]
        public decimal TransactionAmount { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
        public DateTime DatePosted { get; set; }
        
    }
}