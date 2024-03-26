//----------------------------------------
// Tarteeb School (c) All rights reserved
//----------------------------------------

using BudgetReport.Services.Report;

internal class Program
{
    private static void Main(string[] args)
    {
        bool retry = true;

        do
        {
            Console.Clear();
            Console.WriteLine("\t===== Welcome to, my project =====");
            Console.WriteLine("1. MySql ");
            Console.WriteLine("2. ModgoDB ");

            Console.Write("Choose >>>  ");
            string? command = Console.ReadLine();

            if (command.Contains("1") is true)
            {
                IReport budgetReport = new BudgetReporT();
                Console.Clear();
                Console.WriteLine("=== MySql ===");
                Console.WriteLine("1. Open");
                Console.WriteLine("2. Save");

                Console.Write("Choose >>>  ");
                string? commandMySql = Console.ReadLine();

                switch (commandMySql)
                {
                    case "1":
                        var listInfo = budgetReport.Open("Tashkent");
                        foreach (var info in listInfo)
                        {
                            System.Console.WriteLine($"{info}");
                        }
                        break;

                    case "2":
                        System.Console.Write("Enter your message: ");
                        string? message = Console.ReadLine();
                        budgetReport.Save(message);
                        break;
                }
            }

            if (command.Contains("2") is true)
            {
                IReport budgetReport = new BudgetReporT();
                Console.Clear();
                Console.WriteLine("=== MongoDb ===");
                Console.WriteLine("1. Open");
                Console.WriteLine("2. Save");

                Console.Write("Choose >>>  ");
                string? commandMySql = Console.ReadLine();

                switch (commandMySql)
                {
                    case "1":
                        var listInfo = budgetReport.Open("Tashkent");
                        foreach (var info in listInfo)
                        {
                            System.Console.WriteLine($"{info}");
                        }
                        break;

                    case "2":
                        System.Console.Write("Enter your message: ");
                        string? message = Console.ReadLine();
                        budgetReport.Save(message);
                        break;
                }
            }

            Console.Write("Is continue(no or yes): ");
            string? ret = Console.ReadLine();

            if (ret.Contains("no"))
            {
                retry = false;
            }
        } while (retry);

        Console.Clear();
        Console.WriteLine("Thanks, Bye!");
    }
}