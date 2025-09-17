namespace MulticastDelegate
{
    public delegate void RectDelegate(double width, double height);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before Using Multicast Delegate:");
            var helper = new RectangleHelper();
            helper.GetArea(10, 5);
            helper.GetPerimeter(10, 5);

            Console.WriteLine();

            Console.WriteLine("After Using Multicast Delegate:");
            RectDelegate rectDelegate;
            rectDelegate = helper.GetArea;
            rectDelegate += helper.GetPerimeter;
            rectDelegate.Invoke(10, 5); // or rectDelegate(10, 5);

            Console.WriteLine();

            Console.WriteLine("After Delete GetPerimeter:");
            rectDelegate -= helper.GetPerimeter;
            rectDelegate(10, 5);

            Console.ReadKey();
        }
    }

    class RectangleHelper
    {
        public void GetArea(double width, double height)
        {
            var result = width * height;

            Console.WriteLine($" Area = {width} x {height} = {result}");
        }

        public void GetPerimeter(double width, double height)
        {
            var result = 2 * (width + height);

            Console.WriteLine($" Perimeter = 2 x ({width} + {height}) = {result}");
        }
    }
}
