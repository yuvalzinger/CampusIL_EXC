using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIL_EP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Date();
            //Seasons();
            //Show();


            Console.ReadLine();
        }

        public static void Ex1()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num/10==num%10 ? "Equal" : "Not Equal");
        }
        public static void Ex2()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(num % 111 == 0 ? "Equal" : "Not Equal");
        }
        public static void Ex3()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((num/10)+1==num%10 ? "Yes" : "No");
        }
        public static void Ex4()
        {
            int num = int.Parse(Console.ReadLine());
            //Console.WriteLine("{0} == {1}, {2} == {3}", (num / 100) + 1, num % 100 / 10, (num % 100 / 10) + 1, num % 10);
            Console.WriteLine((num / 100)+1 == num%100/10 && (num%100/10)+1 == num%10 ? "Yes" : "No");
        }
        public static void Ex5()
        {
            Console.Write("Enter Max Tank Capacity: ");
            int cap = int.Parse(Console.ReadLine());
            Console.Write("Enter Current Fuel Amount: ");
            int fuel = int.Parse(Console.ReadLine());

            double enoughFuel = 0.15 * cap;

            if (fuel <= enoughFuel)
            {
                Console.WriteLine("Fill Fuel");
            }


        }
        public static void Ex6()
        {
            Console.WriteLine("Enter estimated time: ");
            int ET = int.Parse(Console.ReadLine());

            Console.Write(ET <= 50 ? "Runner is assigned to A\n" : "");
            Console.Write(ET > 50 && ET <= 60 ? "Runner is assigned to B\n" : "");
            Console.Write(ET > 60 ? "Runner is assigned to C\n" : "");
        }
        public static void Date()
        {
            Console.WriteLine("Enter date");
            int num = int.Parse(Console.ReadLine());

            int day = (num / 1000000);
            int month = (num % 100000 / 10000);
            int year = (num % 10000);

            Console.WriteLine("The year is {2}, the month is {1}, and the day is {0}", day, month, year);
        }
        public static void Seasons()
        {
            Console.WriteLine("Enter date");
            int num = int.Parse(Console.ReadLine());
            int month = (num % 1000000 / 10000);
            //Console.WriteLine(month);

            //Spring or Summer
            if (month > 2 && month <= 8)
            {
                if (month <= 5)
                    Console.WriteLine("Spring");
                else
                    Console.WriteLine("Summer");
            }
            //Winter or Autumn
            else
            {
                if (month >= 11)
                    Console.WriteLine("Autumn");
                else
                    Console.WriteLine("Winter");
            }
        }
        public static void Show()
        {

        }
    }
}
