using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CIL_EP6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //p6Ex6_7();
            //p6Ex2();
            //p7Ex1();
            //p7Ex3();
            //p7Ex3();
            //p7Ex6();
            //p7Ex10();
            p7Ex11();

            Console.ReadLine();
        }
        public static void p6Ex7()
        {
            int grd = 1, maxClassGrd, maxYearGrd, countClassGrd = 0, countYearGrd = 0;

            maxClassGrd = int.MinValue;
            maxYearGrd = int.MinValue;

            for (int i = 0; i < 3; i++)
            {
                while (grd > 0)
                {
                    Console.Write("Enter grade: ");
                    grd = int.Parse(Console.ReadLine());
                    if (grd > maxClassGrd)
                    {
                        maxClassGrd = grd;
                        countClassGrd = 0;
                    }
                    if (grd == maxClassGrd)
                        countClassGrd++;
                    //Console.WriteLine(countClassGrd);
                }

                Console.WriteLine($"Best Grade in Class: {maxClassGrd}\nAchieved by: {countClassGrd}");
                if (maxClassGrd > maxYearGrd)
                {
                    maxYearGrd = maxClassGrd;
                    countYearGrd = countClassGrd;
                }
                else if (maxClassGrd == maxYearGrd)
                    countYearGrd += countClassGrd;

                grd = 1;
                maxClassGrd = 1;
                Console.WriteLine("");

            }
            Console.WriteLine($"Best Grade in Year: {maxYearGrd}\nAchieved by: {countYearGrd}");
        }
        public static void p6Ex2()
        {
            int i = 1;
            while (i <= 10)
            {
                for (int j = 1; j <= 10; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
                i++;
            }
        }
        public static void p7Ex1()
        {
            int pack0Price, pack1Price, pack2Price, totalPrice = 0, mostPicked;
            int pack0Count = 0, pack1Count = 0, pack2Count = 0;
            string customerName;
            char chosenPack;

            Console.Write("Enter pack 0 price: ");
            pack0Price = int.Parse(Console.ReadLine());
            Console.Write("Enter pack 1 price: ");
            pack1Price = int.Parse(Console.ReadLine());
            Console.Write("Enter pack 2 price: ");
            pack2Price = int.Parse(Console.ReadLine());

            while (pack0Count < 2 && pack1Count < 2 && pack2Count < 2)
            {
                Console.WriteLine("");
                Console.Write("Enter your name: ");
                customerName = Console.ReadLine();
                Console.Write("What pack will you choose: ");
                chosenPack = char.Parse(Console.ReadLine());
                if (chosenPack == '0')
                {
                    chosenPack = '0';
                    totalPrice = pack0Price;
                    pack0Count++;
                }
                if (chosenPack == '1')
                {
                    chosenPack = '1';
                    totalPrice = pack1Price;
                    pack1Count++;
                }
                if (chosenPack == '2')
                {
                    chosenPack = '2';
                    totalPrice = pack2Price;
                    pack2Count++;
                }

                Console.WriteLine($"{customerName} chose: {chosenPack} \nYour Total Price: {totalPrice}");
            }
            int max = Math.Max(pack0Count, pack1Count);
            mostPicked = Math.Max(pack2Count, max);
            Console.WriteLine($"\nMost picked pack is: {mostPicked}");
        }
        public static void p7Ex3()
        {
            int space, familyMembers, occupiedPlaces, totalPrice, familiesCount = 0;
            string familyName;
            Console.Write("Enter space: ");
            space = int.Parse(Console.ReadLine());
            occupiedPlaces = 0;


            while (occupiedPlaces < space)
            {
                Console.Write("Enter family name: ");
                familyName = Console.ReadLine();
                Console.Write("Enter family members: ");
                familyMembers = int.Parse(Console.ReadLine());

                totalPrice = familyMembers * 100;

                if (familyMembers + occupiedPlaces > space)
                {
                    Console.WriteLine($"{familyName}, not enough places");
                }
                else
                {
                    occupiedPlaces += familyMembers;
                    Console.WriteLine($"{familyName}'s total price: {totalPrice}");
                }
            }
            Console.WriteLine("Total trip expenses: " + occupiedPlaces * 100);
        }
        public static void p7Ex6()
        {
            int swAmnt = 1, wcheeseSW = 10, ycheeseSW = 12, herbsPrice = 1, ordersToday = 0;
            int wCount = 0, yCount = 0, wHerbsCount = 0, yHerbsCount = 0;
            string cheeseChoice, herbsChoice;


            while (swAmnt != 0)
            {
                Console.Write("How much sandwiches do you want? ");
                swAmnt = int.Parse(Console.ReadLine());
                Console.Write("White or Yellow cheese? W/Y ");
                cheeseChoice = Console.ReadLine();
                Console.Write("Would you like herbs? Y/N ");
                herbsChoice = Console.ReadLine();

                if (cheeseChoice == "W")
                {
                    if (herbsChoice == "Y")
                        Console.WriteLine(swAmnt < 10 ? $"Total Price: {(swAmnt * wcheeseSW) + (swAmnt * herbsPrice)}" : $"Total Price: {(wcheeseSW * swAmnt) - 20}");
                    else
                        Console.WriteLine(swAmnt < 10 ? $"Total Price: {(swAmnt * wcheeseSW)}" : $"Total Price: {(swAmnt * wcheeseSW) - 20}");
                }
                else
                {
                    if (herbsChoice == "Y")
                        Console.WriteLine(swAmnt < 10 ? $"Total Price: {(swAmnt * ycheeseSW) + (swAmnt * herbsPrice)}" : $"Total Price: {(swAmnt * ycheeseSW) + (swAmnt * herbsPrice) - 20}");
                    else
                        Console.WriteLine(swAmnt < 10 ? $"Total Price: {(swAmnt * ycheeseSW)}" : $"Total Price: {(swAmnt * ycheeseSW) - 20}");
                }
            }
            Console.WriteLine($"Orders today: {ordersToday}");
        }
        public static void p7Ex10()
        {
            int SSN, j, i = 0, digitSum = 0, nextTen, lastDig, currentNum, digitCheck;
            Console.Write("Enter SSN: ");
            SSN = int.Parse(Console.ReadLine());
            lastDig = SSN % 10;
            SSN = SSN / 10;

            if (SSN > 999999999)
                i++;
            while (SSN>0)
            {
                //
                if (i % 2 == 0)
                    j = 2;
                else
                    j = 1;

                //
                currentNum = (SSN % 10) * j;
                if (currentNum >= 10)
                {
                    digitSum += currentNum / 10 + currentNum % 10;
                }
                else
                    digitSum += currentNum;

                //
                SSN /= 10;
                i++;
            }

            nextTen = ((digitSum / 10) + 1) * 10;
            digitCheck = nextTen - digitSum;
            Console.WriteLine(digitCheck == lastDig ? "Digit is correct" : "Digit is Incorrect");
        }
        public static void p7Ex11()
        {
            int reverseNum = 0, num;


            for (int i = 1000; i < 9999; i++)
            {
                num = i;
                reverseNum = 0;
                //Console.WriteLine("     num: {0}",num);
                while (num > 0)
                {
                    reverseNum *= 10;
                    reverseNum += num % 10;
                    num /= 10;
                    //Console.WriteLine(reverseNum);
                }

                if (i*4==reverseNum)
                    Console.WriteLine(reverseNum);
            }
        }
    }
}