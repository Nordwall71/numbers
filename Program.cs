namespace AreaOfCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"A circle with a radius of {radius} has an area of {AreaOfCircle(radius)}");
        }

        public static double AreaOfCircle(double radius)

        { 
            return Math.PI * Math.Pow(radius, 2); 
        }

        
       
        
           
        


    }
}