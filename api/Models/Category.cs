using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string CategoryName {get; set;} // salary, groceries, etc
        public string CategoryType {get; set;} // income or expense
    }
}