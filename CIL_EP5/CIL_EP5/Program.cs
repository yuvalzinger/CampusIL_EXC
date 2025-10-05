using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIL_EP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4
            //Ex6();
            //Ex8();
            //Ex10();
            Ex13();

            Console.ReadLine();
        }
        public static void Ex1()
        {
            int num, currentPair = 0, prevPair = 0;

            for (int i = 0; i < 218; i++)
            {
                Console.Write("Enter 2 numbers: ");
                num = int.Parse(Console.ReadLine());
                currentPair = num / 10 + num % 10;
                if (currentPair < prevPair)
                {
                    Console.Write("Smaller");
                    Console.WriteLine("");
                }
                prevPair = currentPair;
            }
        }
        public static void Ex2()
        {
            int a, b;
            for (int i = 0; i < 38; i++)
            {
                Console.WriteLine("Enter 2 numbers");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());

                Console.WriteLine(a + b);
                Console.WriteLine(b == 0 ? "Indivisible" : (a / b).ToString());
            }
        }
        public static void Ex3()
        {
            string trackName, above10 = "";
            int trackLength, IsraelTrack = 0;
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter track name: ");
                trackName = Console.ReadLine();
                Console.Write("Enter track length: ");
                trackLength = int.Parse(Console.ReadLine());

                if (trackLength > 10)
                {
                    above10 += trackName + ", ";
                }
                IsraelTrack += trackLength;
            }
            Console.WriteLine("{0} \n{1}", IsraelTrack, above10);
        }
        public static void Ex4()
        {
            string techName;
            int techFixes, fixesToday = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter technician name: ");
                techName = Console.ReadLine();
                Console.Write("Amount of fixes today: ");
                techFixes = int.Parse(Console.ReadLine());

                if (techFixes > 25)
                {
                    Console.WriteLine("BONUS for: {0}", techName);
                }
                fixesToday += techFixes;
                Console.WriteLine("");
            }
            Console.WriteLine(fixesToday);
        }
        public static void Ex6()
        {
            string customerName;
            int customerOrder, totalPrice, whaleCustomers = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter customer's name: ");
                customerName = Console.ReadLine();
                Console.Write("Enter customer's order: ");
                customerOrder = int.Parse(Console.ReadLine());

                totalPrice = customerOrder * 35;
                Console.WriteLine(customerOrder > 4 ? "Thanks {2},\nTotal price: {0}" : "Thanks {2},\nTotal price (with postage): {1}", totalPrice, totalPrice + 10, customerName);
                if (customerOrder > 20)
                {
                    whaleCustomers++;
                }
                Console.WriteLine("");
            }
            Console.WriteLine(whaleCustomers);
        }
        public static void Ex8()
        {
            string donatorName, donatorBT;
            int yearOfBirth, typeO = 0, typeAB = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter donator name: ");
                donatorName = Console.ReadLine();
                Console.Write("Enter donator year of birth: ");
                yearOfBirth = int.Parse(Console.ReadLine());
                Console.Write("Enter donator bt: ");
                donatorBT = Console.ReadLine();

                if (donatorBT == "O")
                    typeO++;
                if (donatorBT == "AB")
                    typeAB++;

                Console.WriteLine("");
            }
            Console.WriteLine("Universal Donators: {0},\nUniversal Recievers: {1}", typeO, typeAB);
        }
        public static void Ex10()
        {
            string studentName;
            int firstWork, secondWork, thirdWork, topStudents = 0;
            double finalScore = 0;

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter student name: ");
                studentName = Console.ReadLine();
                Console.Write("Enter student first work grade: ");
                firstWork = int.Parse(Console.ReadLine());
                Console.Write("Enter student second work grade: ");
                secondWork = int.Parse(Console.ReadLine());
                Console.Write("Enter student third work grade: ");
                thirdWork = int.Parse(Console.ReadLine());

                finalScore = (double)(firstWork + secondWork + thirdWork) / 3;
                if (thirdWork > 85)
                {
                    finalScore += 5;
                    if (finalScore > 100)
                        finalScore = 100;
                }

                Console.WriteLine("{0}, Your final score is: {1}\n", studentName, finalScore);
            }
            Console.WriteLine(topStudents);
        }
        public static void Ex13()
        {
            int hypnosisTickets, ziplineTickets, totalPrice; 
            int hypnosis = 10, zipline = 15, dayRevenue = 0;
            
            for (int i = 0; i < 4; i++)
            {
                Console.Write("How much hypnosis tickets?");
                hypnosisTickets = int.Parse(Console.ReadLine());
                Console.Write("How much zipline tickets?");
                ziplineTickets = int.Parse(Console.ReadLine());

                totalPrice = (hypnosisTickets * 10) + (ziplineTickets * 15);
                Console.WriteLine("Your Total Price: {0}", totalPrice);

                dayRevenue += totalPrice;
                Console.WriteLine("");
            }
            Console.WriteLine("Total day revenue: {0}", dayRevenue);
            Console.WriteLine($"Total day revenue: {dayRevenue}");
        }
    }
}
