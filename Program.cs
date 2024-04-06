using ExpenseTracker;
ExpenseTrackers expenseTrackers = new ExpenseTrackers();
bool exit = false;
string fileName = "C:\\Users\\Segun\\OneDrive\\Desktop\\class_with_tifey\\ExpenseTracker\\expenses.json";

while (!exit)
{
    Console.WriteLine("Expense Tracker Menu:");
    Console.WriteLine("1. Add Expense");
    Console.WriteLine("2. Display Expenses");
    Console.WriteLine("3. Save Expenses");
    Console.WriteLine("4. Load Expenses");
    Console.WriteLine("5. Exit");

    Console.WriteLine("What do you want to do today?");
    int choice = int.Parse(Console.ReadLine()); // this is to ensure that the value is an integer
    switch (choice)
    {
        case 1:
            Console.WriteLine("Enter amount");
            decimal amount = decimal.Parse(Console.ReadLine()); // this is to ensure that the value is a decimal, it is preferable to use decimal when dealing with money
            Console.WriteLine("Specify a category");
            string category = Console.ReadLine();
            Console.WriteLine("Enter date (YYYY-MM-DD)");
            DateTime date = DateTime.Parse(Console.ReadLine()); // DateTime is preferable when dealing with dates
            Console.WriteLine("Enter description: ");
            string description = Console.ReadLine();
            expenseTrackers.AddExpense(amount, category, date, description);
            break;
        case 2:
            expenseTrackers.DisplayExpensesFromList();
            break;
        case 3:
            expenseTrackers.SaveExpenses(fileName);
            break;
        case 4:
            expenseTrackers.DisplayExpensesFromFile(fileName);
            break;
        case 5:
            exit = true;
            break;

        default:
            Console.WriteLine("Invalid choice. Please try again");
            break;

    }
}



