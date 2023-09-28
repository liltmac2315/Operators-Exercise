using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // For division, create interger variables called a and b.
            var a = 17;
            var b = 4;
            var quotient = a / b;
            var remainder = a % b;


            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");

            

           

            Console.WriteLine(AreaOfCircle());
        }

            // Define a method - which performs a functionality.
            // that can be use over and over again.
            public static double AreaOfCircle()
            {
                Console.WriteLine("Please enter the radius of your circle:");
                var radius = double.Parse(Console.ReadLine());
                var area = Math.PI * Math.Pow(radius, 2);
            
                return area;
        
            }
          
    }
}
