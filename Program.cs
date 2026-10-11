using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Numerics;
using static System.Console;

namespace banking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = 100000;
            int workeramn = 0;
            int iron = 0;
            int cogwheels = 0;

            Console.WriteLine(money);
            Console.WriteLine("PRESS: L for LOAN,  M for MARKET, B for BALANCE, H for HELP, S for STATS, C for CONFIGURE, A for PASS ONE MONTH");


            while (true)
            {
                if (KeyAvailable)
                {
                    var input = Console.ReadKey(true);
                    if (input.Key == ConsoleKey.B)
                    {
                        Console.Write(
                            "\n" +
                            "### ### #   ### # #  ## ### \n" +
                            "# # # # #   # # ### #   #   \n" +
                            "##  ### #   ### # # #   ### \n" +
                            "# # # # #   # # # # #   #   \n" +
                            "### # # ### # # # #  ## ### \n" +
                            "----------------------------\n" +
                            $"BALANCE: {money}\n" +
                            "\n"
                        );
                    }
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


                    if (input.Key == ConsoleKey.M)
                    {
                        Console.Write(
                            "\n" +
                            $"BALANCE: {money}\n" +
                            "Z : 10 iron\n" +
                            "price : 10$\n" +
                            "X : 1 worker\n" +
                            "worker cost for upkeep : 1 iron, produces : 1 gear : 20$\n" +
                            $"workers employed: {workeramn}\n" +
                            "\n"
                        );
                    }
                    else if (input.Key == ConsoleKey.Z)
                    {
                        iron++;
                        money -= 10;
                    }
                    else if (input.Key == ConsoleKey.X)
                    {
                        workeramn++;
                    }


                    if (input.Key == ConsoleKey.S)
                    {
                        Console.Write(
                            "\n" +
                            $"BALANCE: {money}\n" +
                            $"WORKERS: {workeramn}\n" +
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
                            "CHANGE WORK-HOURS" +
                            "\n"
                        );
                    }
                    else if (input.Key == ConsoleKey.Z)
                    {
                        int workerpay = 0;
                        Console.Write("PAY $ : ");
                        workerpay = int.Parse(Console.ReadLine());
                    }

                    if (input.Key == ConsoleKey.A)
                    {
                        Console.Write(
                            "\n" +
                            "" +
                            "\n"
                        );
                    }


                }
            }
        }
    }
}