namespace AfterDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            var emps = new Employee[]
            {
                new Employee { Id = 1, Name = "Issam A", TotalSales = 65000, Gender = "M"} ,
                new Employee { Id = 2, Name = "Reem S", TotalSales = 50000, Gender = "F"} ,
                new Employee { Id = 3, Name = "Suzan B", TotalSales = 65000, Gender = "F"} ,
                new Employee { Id = 4, Name = "Sara A", TotalSales = 40000, Gender = "F"} ,
                new Employee { Id = 5, Name = "Salah S", TotalSales = 42000, Gender = "M"} ,
                new Employee { Id = 6, Name = "Rateb A", TotalSales = 30000, Gender = "M"} ,
                new Employee { Id = 7, Name = "Abeer C", TotalSales = 16000, Gender = "F"} ,
                new Employee { Id = 8, Name = "Marwan M", TotalSales = 15000, Gender = "M"}
            };

            var report = new Report();

            // Using "Regular Method" Syntax
            Console.WriteLine("Using Regular Method Syntax\n");
            report.ProcessEmployee(emps, "Employees With Sales 60,000+", IsGreaterThanOrEqual60000);
            report.ProcessEmployee(emps, "Employees With Sales between 30,000 and 59,999", IsBetween30000And59999);
            report.ProcessEmployee(emps, "Employees With Sales less than 30,000", IsLessThan30000);

            // Using "Anonymous Method" Syntax = Simple way to create inline methods, especially useful when working with delegates or events.
            Console.WriteLine("Using Anonymous Method Syntax\n");
            report.ProcessEmployee(emps, "Employees With Sales 60,000+", delegate (Employee e) { return e.TotalSales >= 60000; });
            report.ProcessEmployee(emps, "Employees With Sales between 30,000 and 59,999", delegate (Employee e) { return e.TotalSales >= 30000 && e.TotalSales < 60000; });
            report.ProcessEmployee(emps, "Employees With Sales less than 30,000", delegate (Employee e) { return e.TotalSales < 30000; });

            // Using "Lambda Expression" Syntax = Simple way to create inline methods, especially useful when working with delegates or events.
            Console.WriteLine("Using Lambda Expression Syntax\n");
            report.ProcessEmployee(emps, "Employees With Sales 60,000+", e => e.TotalSales >= 60000);
            report.ProcessEmployee(emps, "Employees With Sales between 30,000 and 59,999", e => e.TotalSales >= 30000 && e.TotalSales < 60000);
            report.ProcessEmployee(emps, "Employees With Sales less than 30,000", e => e.TotalSales < 30000);

            Console.ReadKey();
        }

        static bool IsGreaterThanOrEqual60000(Employee e) => e.TotalSales >= 60000;
        static bool IsBetween30000And59999(Employee e) => e.TotalSales >= 30000 && e.TotalSales < 60000;
        static bool IsLessThan30000(Employee e) => e.TotalSales < 30000;
    }
}
