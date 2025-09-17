using System;

namespace BeforeDelegates
{
    public class Report
    {
        public void ProcessEmployeeWithSales60000Plus(Employee[] employees)
        {
            Console.WriteLine("Employees With Sales $60,000+");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var e in employees)
            {
                if (e.TotalSales >= 60000)
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
                }
            }

            Console.WriteLine("\n\n");
        }

        public void ProcessEmployeeWithSalesBetween30000And59999(Employee[] employees)
        {
            Console.WriteLine("Employees With Sales between $30,000 and $59,999");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var e in employees)
            {
                if (e.TotalSales >= 30000 && e.TotalSales < 60000)
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
                }
            }

            Console.WriteLine("\n\n");
        }

        public void ProcessEmployeeWithSalesLessThan30000(Employee[] employees)
        {
            Console.WriteLine("Employees With Sales less than $30,000");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var e in employees)
            {
                if (e.TotalSales < 30000)
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
                }
            }

            Console.WriteLine("\n\n");
        }
    }
}
