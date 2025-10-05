using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace CIL_EP9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //p4ex1();
            //p4ex2();
            //p4ex3();
            //p4ex4();

            //p5ex1();
            //p5ex2();
            p5ex3();

            Console.ReadLine();
        }

        #region p4ex1
        public static void p4ex1()
        {
            Console.Write("How many stores? ");
            int n = int.Parse(Console.ReadLine());

            int[] totals = StoreTotals(n);

            Console.WriteLine("\nTotals:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Store " + (i + 1) + ": " + totals[i]);
            }
        }
        static int[] StoreTotals(int numStores)
        {
            int[] totals = new int[numStores];

            for (int i = 0; i < numStores; i++)
            {
                Console.WriteLine("Enter purchases for store " + (i + 1) + " (negative to stop):");
                int sum = 0;
                int x = int.Parse(Console.ReadLine());
                while (x >= 0)
                {
                    sum += x;
                    x = int.Parse(Console.ReadLine());
                }
                totals[i] = sum;
            }

            int totalAll = 0;
            for (int i = 0; i < numStores; i++)
            {
                totalAll += totals[i];
            }
            double avg = (double)totalAll / numStores;

            Console.WriteLine("\nAverage = " + avg);
            Console.WriteLine("Stores above average:");
            for (int i = 0; i < numStores; i++)
            {
                if (totals[i] > avg)
                    Console.WriteLine("Store " + (i + 1));
            }

            return totals;
        }

        #endregion
        #region p4ex3
        public static void p4ex3()
        {
            int[] votes = new int[12];
            int vote = 0;

            Console.WriteLine("Enter votes (1-12). Type -1 to finish:");

            while (vote != -1)
            {
                vote = int.Parse(Console.ReadLine());

                if (vote >= 1 && vote <= 12)
                    votes[vote - 1]++;
                else if (vote != -1)
                    Console.WriteLine("Invalid vote. Please enter 1-12 or -1 to stop.");
            }

            int maxVotes = votes[0];
            int winner = 1;

            for (int i = 1; i < votes.Length; i++)
            {
                if (votes[i] > maxVotes)
                {
                    maxVotes = votes[i];
                    winner = i + 1;
                }
            }

            Console.WriteLine($"The winner is candidate number: {winner}");



        }

        #endregion
        #region p4ex4
        //public static void p4ex4()
        //{
        //    int[] players = new int[78];
        //    int player = 0, goalCount = 0;

        //    while (player != -1)
        //    {
        //        Console.Write("Enter a player 1-78, enter -1 to stop: ");
        //        player = int.Parse(Console.ReadLine());

        //        if (player >= 1 && player <= 78)
        //        {
        //            goalCount++;
        //            players[player - 1]++;
        //        }
        //        else if (player != -1)
        //            Console.WriteLine("Player not found. Please enter a player 1-78 or -1 to stop.");
        //    }

        //    int maxGoals = players[0];
        //    int winner = 1;

        //    for (int i = 1; i < players.Length; i++)
        //    {
        //        if (players[i] > maxGoals)
        //        {
        //            maxGoals = players[i];
        //            winner = i + 1;
        //        }
        //    }
        //    for (int i = 0; i < players.Length; i++)
        //    {
        //        if (players[i] >)
        //    }
        //}
        public static void p4ex4()
        {
            int players = 78;
            int games = 3;

            int[] totalGoals = new int[players + 1];
            int[] gamesPlayed = new int[players + 1];

            for (int g = 1; g <= games; g++)
            {
                Console.WriteLine($"Game {g}: enter player number and goals. End with -1");

                Console.Write("Player number: ");
                int player = int.Parse(Console.ReadLine());

                while (player != -1)
                {
                    Console.Write("Goals scored: ");
                    int goals = int.Parse(Console.ReadLine());

                    totalGoals[player] = totalGoals[player] + goals;
                    gamesPlayed[player] = gamesPlayed[player] + 1;

                    Console.Write("Player number: ");
                    player = int.Parse(Console.ReadLine());
                }
            }

            int maxGoals = -1;
            int topScorer = -1;

            for (int i = 1; i <= players; i++)
            {
                if (totalGoals[i] > maxGoals)
                {
                    maxGoals = totalGoals[i];
                    topScorer = i;
                }
            }

            double maxAvg = -1;
            int bestScorer = -1;

            for (int i = 1; i <= players; i++)
            {
                if (gamesPlayed[i] > 0)
                {
                    double avg = (double)totalGoals[i] / gamesPlayed[i];

                    if (avg > maxAvg)
                    {
                        maxAvg = avg;
                        bestScorer = i;
                    }
                }
            }

            Console.WriteLine($"Top scorer is player: {topScorer}");
            Console.WriteLine($"Best scorer is player: {bestScorer}");
        }

        #endregion

        #region p5ex1
        public static void p5ex1()
        {
            int[] a = { 2, 8, 17, 14, 42, 11, 5, 12 };

            Console.WriteLine(Igloo(a, 50));
        }
        public static int Igloo(int[] a, int num)
        {
            int lessThanNum = 0;

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] < num)
                    lessThanNum++;

                if (a[i] == num)
                    return lessThanNum;
            }

            return lessThanNum;
        }


        #endregion
        #region p5ex2
        public static void p5ex2()
        {
            string[] arr = { "dog", "cat", "do", "horse", "scot", "piggy", "p" };
            Console.WriteLine($"Amount of strings of {3}: {Exact(arr, 3)}");
        }
        public static int Exact(string[] arr, int num)
        {
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length == num)
                    count++;
            }
            return count;
        }

        #endregion
        #region p5ex3
        public static void p5ex3()
        {
            int[] a = { 3, 5, 9, 4, 9 };
            Console.WriteLine($"{Big(a)}");
        }
        public static int Big(int[] arr)
        {
            int max = arr[0];
            int index = 0;

            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                    index = i;
                }
            }

            return index;
        }

        #endregion
    }
}
    