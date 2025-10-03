using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIL_EP8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //p8ex7();
            //p8ex8();
            //p8ex9();
            //p8ex10();
            p8ex12();

            Console.ReadLine();
        }
        public static void p8ex7()
        {
            int count = 0;
            Console.Write("Enter amount of students: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.Write("Enter name: ");
                string s = Console.ReadLine();
                for (int j = 0; j < s.Length; j++)
                {
                    if (s[j] == 'C' || s[j] == 'c')
                    {
                        //sub length: 5
                        //were at j
                        //wall at s.length
                        if (5 + j <= s.Length)
                        {
                            string substring = s.Substring(j, 5);
                            Console.WriteLine(substring);
                            if (substring == "Cohen" || substring == "cohen")
                            {
                                count++;
                            }
                        }
                    }
                }
            }

            Console.WriteLine(count);
        }
        public static void p8ex8()
        {
            Console.Write("Enter string 1: ");
            string s1 = Console.ReadLine();
            Console.Write("Enter string 1: ");
            string s2 = Console.ReadLine();

            string news1 = s1.Replace(s1[0], s2[0]);
            news1 = s1.Replace(s1[1], s2[1]);
            string news2 = s2.Replace(s2[0], s1[0]);
            news2 = s2.Replace(s2[1], s1[1]);

            Console.WriteLine($"New string 1: {news1}\nNew string 2: {news2}");
        }
        public static void p8ex9()
        {
            Console.Write("Enter string: ");
            string s1 = Console.ReadLine();

            if (s1.Length > 3)
            {
                string first3 = s1.Substring(0, 3);
                string last3 = s1.Substring(s1.Length - 3, 3);

                Console.WriteLine($"{first3}, {last3}");
            }
            else
                Console.WriteLine("***");

        }
        public static void p8ex10()
        {
            Console.Write("Enter string 1: ");
            string s1 = Console.ReadLine();

            int firstSpace = s1.IndexOf(' ');
            int lastSpace = s1.LastIndexOf(' ');

            string firstWord = s1.Substring(0, firstSpace);
            string lastWord = s1.Substring(lastSpace, s1.Length - lastSpace);
            Console.WriteLine($"{firstWord}{lastWord}");
        }
        //public static void p8ex12()
        //{
        //    Console.Write("Enter string 1: ");
        //    string str = Console.ReadLine();

        //    int firstSpace = str.IndexOf(' ');

        //    string firstWord = str.Substring(0, firstSpace);
        //    Console.WriteLine(firstWord);
        //    string secondWord = str.Substring(firstSpace + 1, str.IndexOf(' ') + 1);
        //    Console.WriteLine(secondWord);
        //    string thirdWord = secondWord.Substring(firstSpace + 1, secondWord.IndexOf(' ') + 1);
        //    Console.WriteLine(thirdWord);

        //}
        public static void p8ex12()
        {
            string s = Console.ReadLine(), p ="";
            for (int i = 0; i < s.Length; i++)
            {
                if ((i > 0 && s[i - 1] == ' ') || (i == 0))
                    p += s[i];
            }
            Console.WriteLine(p);
        }
    }
}
