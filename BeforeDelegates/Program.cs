namespace BeforeDelegates
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

            report.ProcessEmployeeWithSales60000Plus(emps);
            report.ProcessEmployeeWithSalesBetween30000And59999(emps);
            report.ProcessEmployeeWithSalesLessThan30000(emps);

            Console.ReadKey();
        }
    }
}
