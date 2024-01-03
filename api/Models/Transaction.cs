using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Transaction
    {
        public int Id { get; set; }
        public User User {get; set;}
        public int Amount {get; set;}
        public string Description {get; set;}
        public DateTime TransactionDate {get; set;}
        public Category Category {get; set;}
        public Account Account {get; set;}
    }
}