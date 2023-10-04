using System.Security.Cryptography.X509Certificates;

namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Define the variables
            int a = 17;
            int b = 4;

            // Addition
            int additionResult = a + b;
            Console.WriteLine($"Addition: {a} + {b} = {additionResult}");

            // Subtraction
            int subtractionResult = a - b;
            Console.WriteLine($"Subtraction: {a} - {b} = {subtractionResult}");

            // Multiplication
            int multiplicationResult = a * b;
            Console.WriteLine($"Multiplication: {a} * {b} = {multiplicationResult}");

            // Division (casting one operand to double for floating-point division)
            double divisionResult = (double)a / b;
            Console.WriteLine($"Division: {a} / {b} = {divisionResult}");

            // Modulus (remainder)
            int modulusResult = a % b;
            Console.WriteLine($"Modulus: {a} % {b} = {modulusResult}");

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

                Console.WriteLine(AreaOfCircle());
            }

                
            }
        }























