using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using static System.Console;



namespace banking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            ConsoleKeyInfo input = new();

            int money = 100000;
            int iron = 0;
            int cogwheels = 0;
            int day = 0;

            int workerAmount = 0;
            int workerpay = 0;
            int workerhappy = 100;

            bool gameon = true;

            void Day(int money, int iron, int cogwheels, int workerAmount, int workerhappy, int workerpay, int day)
            {
                Console.Write(
                    "\n" +
                    "\n" +
                    "\n"
                );
                day++;
                iron -= workerAmount;
                cogwheels += workerAmount;

                if (day % 30 == 0) 
                {
                    money -= workerpay * workerAmount; 
                    if (workerpay == 0)
                    {
                        money -= money / 5;
                    }
                }
                money -= (100 - workerhappy) * 1000;
            }

            void Market(ConsoleKeyInfo input, int money, int iron, int cogwheels)
            {

                if (input.Key == ConsoleKey.M)
                {
                    Console.Write(
                        "\n" +
                        $"BALANCE: {money}\n" +
                        "Z : 10 iron\n" +
                        "price : 10$\n" +
                        "X : 1 worker\n" +
                        "worker cost for upkeep : 1 iron, produces : 1 gear : 20$\n" +
                        $"workers employed: {workerAmount}\n" +
                        "\n"
                    );
                }
                if (input.Key == ConsoleKey.Z)
                {
                    iron++;
                    money -= 10;
                }
                if (input.Key == ConsoleKey.X)
                {
                    workerAmount++;
                }
                if (input.Key == ConsoleKey.C)
                {
                    iron--;
                    money += 8;
                }
                if (input.Key == ConsoleKey.V)
                {
                    cogwheels--;
                    money += 20;
                }
            }

            void startup(int money, int iron, int cogwheels, int workerAmount, int workerhappy, int workerpay, int day)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(money);
                Console.SetCursorPosition(10, 0);
                Console.Write(iron);
                Console.SetCursorPosition(15, 0);
                Console.Write(workerAmount);
                Console.SetCursorPosition(20, 0);
                Console.Write(cogwheels);
                Console.SetCursorPosition(25, 0);
                Console.Write(workerhappy);
            }

            Console.SetCursorPosition(0, 1);
            Console.WriteLine("PRESS: L for LOAN,  M for MARKET, H for HELP, S for STATS, C for CONFIGURE, A for PASS ONE DAY");


            /*      
            //clears
           if (0 == 2)
           {
               for (int i = 0; i < 20; i++)
               {
                   Console.SetCursorPosition(0, i + 4);
                   Console.WriteLine("                                                                                                                           ");
               }
           }
           //clears

           Console.SetCursorPosition(0, 4);

           if (input.Key == ConsoleKey.L)
           {
               Console.Write(
                   "\n" +
                   "#   ### ### # # ### \n" +
                   "#   # # # # ### #   \n" +
                   "#   # # ### # # ### \n" +
                   "#   # # # # # #   # \n" +
                   "### ### # # # # ### \n" +
                   "--------------------\n" +
                   "LOANS:\n" +
                   "MONEY 1,2,3  --  10 000, 100 000, 1 000 000\n" +
                   "MORTGAGE 1,2,3  --  1 factory, 10 factories, 100 factories\n" +
                   "\n"
               );
           }

           if (input.Key == ConsoleKey.H)
           {
               Console.Write(
                   "\n" +
                   "# # ### #   ### \n" +
                   "# # #   #   # # \n" +
                   "### ### #   ### \n" +
                   "# # #   #   #   \n" +
                   "# # ### ### #   \n" +
                   "----------------\n" +
                   "HELLO\n" +
                   "you are a capitalist, this is a game about owning 'resources', 'factories' and 'workers'\n" +
                   "take out loans, buy people and buildings.\n" +
                   "engage in bourgois antics, kill, be killed and own your fellow man like god intended\n" +
                   "remember you earned this, not through hard work, no, through luck and exploitation you have 'earned'\n" +
                   "a 'small modest loan' of 1 000 000$\n" +
                   "and now you shall have 'fun' make money at any cost and make your patron proud!\n" +
                   "--------------------\n" +
                   "PRESS: L for LOAN,  M for MARKET, B for BALANCE, H for HELP, S for STATS, C for CONFIGURE\n" +
                   "\n"
               );
           }


           if (input.Key == ConsoleKey.S)
           {
               Console.Write(
                   "\n" +
                   $"BALANCE: {money}\n" +
                   $"WORKERS: {workerAmount}\n" +
                   $"IRON: {iron}\n" +
                   $"COGWHEELS: {cogwheels}\n" +
                   "\n"
               );
           }


           if (input.Key == ConsoleKey.C)
           {
               Console.Write(
                   "\n" +
                   "CHANGE WORKER PAY : Z\n" +
                   "CHANGE WORK-HOURS\n" +
                   "\n"
               );
           }
           if (input.Key == ConsoleKey.Z)
           {
               Console.Write("PAY $ : ");
               workerpay = int.Parse(Console.ReadLine());
           }
           */

            int option = 0;

            while (gameon)
            {
                //shows stats
                startup(money, iron, cogwheels, workerAmount, workerhappy, workerpay, day);
                //show stats

                if (KeyAvailable)
                {
                    input = Console.ReadKey(true);

                    //czech option
                    if (input.Key == ConsoleKey.M)
                    {
                        option = 1;
                    }
                    if (input.Key == ConsoleKey.D)
                    {
                        Day(money, iron, cogwheels, workerAmount, workerhappy, workerpay, day);
                    }
                    //czech option

                    if (input.Key == ConsoleKey.Escape) option = 0;

                    //options
                    if (option == 1)
                    {
                        Market(input, money, iron, cogwheels);
                    }
                    //options
                }


            }

        }
    }
}