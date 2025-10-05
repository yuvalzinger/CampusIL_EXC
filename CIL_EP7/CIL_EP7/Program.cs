using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CIL_EP7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //p4ex3();
            //p4ex4();
            //p4ex6();
            p4ex8();

            Console.ReadLine();
        }
        #region p4ex3
        public static void p4ex3()
        {
            int totalGiftCards = 0;
            int customersWithGifts = 0;

            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Customer {i} \nEnter years in company: ");
                int years = int.Parse(Console.ReadLine());

                Console.Write("Enter monthly: ");
                int amount = int.Parse(Console.ReadLine());

                int gift = GiftCard(years, amount);

                if (gift > 0)
                {
                    customersWithGifts++;
                    totalGiftCards += gift;
                }
            }

            Console.WriteLine($"Amount of customers that got gift cards: {customersWithGifts}");
            Console.WriteLine($"Total gift cards: {totalGiftCards} ");
        }
        public static int GiftCard(int years, int amount)
        {
            if (years > 3 && amount > 1200)
            {
                if (years < 8)
                    return years * 50;
                else
                    return years * 100;
            }

            return 0;
        }
        #endregion
        #region p4ex4
        public static void p4ex4()
        {
            int boysCount = 0;
            int girlsCount = 0;

            for (int i = 0; i < 4; i++)
            {
                Console.Write("Enter month of birth: ");
                int month = int.Parse(Console.ReadLine());
                Console.Write("Enter year of birth: ");
                int year = int.Parse(Console.ReadLine());
                Console.Write("Enter gender of baby: ");
                char gender = char.Parse(Console.ReadLine());

                if (IsInRange(month, year) == true)
                {
                    if (gender == 'b')
                        boysCount++;
                    else if (gender == 'g')
                        girlsCount++;
                }
            }

            Console.WriteLine($"Number of boys: {boysCount}");
            Console.WriteLine($"Number of girls: {girlsCount}");
        }
        public static bool IsInRange(int month, int year)
        {
            return (year == 2009 && month >= 1 && month <= 6);
        }
        #endregion
        #region p4ex6
        public static void p4ex6()
        {
            CorrectAmtPerMachine();
        }
        public static void CorrectAmtPerMachine()
        {
            int standardSize, capAmt;

            for (int i = 1; i < 4; i++)
            {
                Console.Write("Enter standard size: ");
                standardSize = int.Parse(Console.ReadLine());
                Console.Write("Enter caps made today: ");
                capAmt = int.Parse(Console.ReadLine());
                Console.WriteLine($"Machine {i} Done.\nProduced {Check(standardSize, capAmt)} correct caps");
                Console.WriteLine("");
            }
        }
        public static int Check(int standardSize, int capAmt)
        {
            int capSize, capCount = 0;

            for (int i = 1; i <= capAmt; i++)
            {
                Console.Write("Enter cap size: ");
                capSize = int.Parse(Console.ReadLine());
                if (Math.Abs(standardSize - capSize) <= 1)
                    capCount++;
            }
            return capCount;
        }
        #endregion
        #region p4ex8
        public static void p4ex8()
        {
            int numOfProducts, shippingNotFree = 0;
            //

            for (int i = 0; i < 3; i++)
            {
                Console.Write("How many products? ");
                numOfProducts = int.Parse(Console.ReadLine());
                if (IsShippingFree(numOfProducts))
                    shippingNotFree++;
            }
            Console.WriteLine($"Customers that have to pay: {shippingNotFree}");
        }
        public static bool IsShippingFree(int numOfProducts)
        {
            //Order over 150->Free Shipping
            int prodPrice, totalPrice = 0;

            for (int i = 0; i < numOfProducts; i++)
            {
                Console.Write("Product price: ");
                prodPrice = int.Parse(Console.ReadLine());
                totalPrice += prodPrice;
                Console.WriteLine(totalPrice > 150 ? "Your Shipping is free" : "You have to pay for shipping");
            }
            if (totalPrice > 150)
                return true;

            return false;
        }
        #endregion
    }
}