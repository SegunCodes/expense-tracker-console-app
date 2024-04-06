using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpenseTracker
{
    public class Expense // this class wll be used to receive expense info from the user
    {
        public decimal Amount { get; set; }
        public string Category { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public Expense(decimal amount, string category, DateTime date, string description) 
        { 
            Amount = amount;
            Category = category;
            Date = date;
            Description = description;
        }
    }
}
