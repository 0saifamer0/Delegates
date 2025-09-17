namespace AfterDelegates
{
    public delegate bool delegateSales(Employee e);

    public class Report
    {
        public void ProcessEmployee(Employee[] employees, string title, delegateSales delegateSales)
        {
            Console.WriteLine(title);
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            foreach (var e in employees)
            {
                if (delegateSales.Invoke(e))
                {
                    Console.WriteLine($"{e.Id} | {e.Name} | {e.Gender} | ${e.TotalSales}");
                }
            }

            Console.WriteLine("\n\n");
        }
    }
}
