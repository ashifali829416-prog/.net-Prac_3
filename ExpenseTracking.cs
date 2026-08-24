using System;

class ExpenseTracker
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("Enter Expense ID: ");
            int expenseId = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Expense Name: ");
            string expenseName = Console.ReadLine();

            Console.Write("Enter Expense Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            if (amount < 0)
            {
                throw new Exception("Expense amount cannot be negative.");
            }

            Console.WriteLine("\n----- Expense Details -----");
            Console.WriteLine("Expense ID: " + expenseId);
            Console.WriteLine("Expense Name: " + expenseName);
            Console.WriteLine("Expense Amount: ₹" + amount);
        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid input! Please enter the correct data type.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("\nProgram Executed Successfully.");
        }

        Console.ReadKey();
    }
}
