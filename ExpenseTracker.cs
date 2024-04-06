using ExpenseTracker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json; // to store data in form of json

namespace ExpenseTracker
{
    public class ExpenseTrackers // will be used to perform operations on expense(s)
    {
        private List<Expense> expenses = new List<Expense>(); // get all data from program.cs and send it to Expense class
        // method to add expense
        public void AddExpense(decimal amount, string category, DateTime date, string description) 
        {
            expenses.Add(new Expense(amount, category, date, description));
            Console.WriteLine(expenses.Count);
        }

        // method to save expenses to a json file
        public void SaveExpenses(string fileName)
        {
            string json = JsonSerializer.Serialize(expenses); // convert list data to json format
            File.WriteAllText(fileName, json); // store the converted list data in a json file
            Console.WriteLine("saved successfully");
        }

        // method to load expenses
        public void DisplayExpensesFromFile(string fileName)
        {
            if (File.Exists(fileName)) //check if the file is existing
            {
                string json = File.ReadAllText(fileName); // get all the data from the file
                expenses = JsonSerializer.Deserialize<List<Expense>>(json); // convert from json back to the list
                foreach (var expense in expenses)
                {
                    Console.WriteLine($"Amount: {expense.Amount}, Category: {expense.Category}, Date: {expense.Date}, Description: {expense.Description}");
                }
                Console.WriteLine("Expenses loaded successfully!");
            }
            else
            {
                Console.WriteLine("No file found.");
            }
        }

        // method to display expenses
        public void DisplayExpensesFromList()
        {
            foreach (var expense in expenses)
            {
                Console.WriteLine($"Amount: {expense.Amount}, Category: {expense.Category}, Date: {expense.Date}, Description: {expense.Description}");
            }
        }

    }
}
