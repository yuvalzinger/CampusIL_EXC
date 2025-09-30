using System;
using System.ComponentModel.Design;

namespace CIL_EP5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex6();

            Console.ReadLine();
        }

        public static void Ex1()
        {
            Console.Write("Enter Price: ");
            int basePrice = int.Parse(Console.ReadLine());
            Console.Write("Enter Row: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Enter Discount: ");
            int discount = int.Parse(Console.ReadLine());

            if (row < 2)
                Console.WriteLine("Price: {0}", basePrice + 50);
            else if (row < 10)
                Console.WriteLine("Price: {0}", basePrice - (discount * row));
            else
                Console.WriteLine("Price: {0}", basePrice / 3);

        }
        public static void Ex2()
        {
            Console.Write("Enter Total Price: ");
            int totalPrice = int.Parse(Console.ReadLine());
            Console.Write(totalPrice < 100 ? "Total Price: {0}\n" : "", totalPrice * 0.95);
            Console.Write(totalPrice >= 100 && totalPrice < 200 ? "Total Price: {0}\n" : "", totalPrice * 0.90);
            Console.Write(totalPrice >= 200 && totalPrice < 500 ? "Total Price: {0}\n" : "", totalPrice * 0.85);
            Console.Write(totalPrice > 500 ? "Total Price: {0}\n" : "", totalPrice * 0.80);
        }
        public static void Ex3()
        {
            Console.Write("Enter a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter b: ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Enter c: ");
            int c = int.Parse(Console.ReadLine());

            double solutionPlus = (-b + Math.Sqrt(b * b - 4 * (a * c))) / 2 * a;
            double solutionMinus = (-b - Math.Sqrt(b * b - 4 * (a * c))) / 2 * a;

            if (a == 0)
            {
                if (b == 0)
                    Console.WriteLine("y = {0}\n Function has no solutions.", c);
                else
                    Console.WriteLine("y = {0}x + {1} \nFunction is Linear.\nSolution: ({2}, 0)", b, c, (-c / (2 * b)));
            }
            else
            {
                Console.WriteLine("y = {0}x² + {1}x + {2} \nFunction is Not Linear.", a, b, c);
                Console.WriteLine("Solutions: x₁ = {0}, x₂ = {1}", solutionPlus, solutionMinus);
            }
        }
        public static void Ex6()
        {
            Console.Write("Enter driver's age: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Enter years licensed: ");
            double years = double.Parse(Console.ReadLine());

            if (years < 2)
            {
                if (age < 24)
                {
                    if (years < 0.5)
                        Console.WriteLine("Young Driver with Supervisor");
                }
                else 
                    Console.WriteLine("New Driver");
            }
            else if (age > 24)
                Console.WriteLine("Veteran Driver");
            else
                Console.WriteLine("Young Driver");
        }
    }
}