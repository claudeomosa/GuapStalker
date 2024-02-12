using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Account
    {
        public int Id { get; set; }
        public User User {get; set;}
        public string AccountNumber {get; set;}
        public string AccountName {get; set;}
        public int Balance {get; set;}
        public string AccountType {get; set;}
        public string Status {get; set;}
        public DateTime CreatedAt {get; set;}
    }
}