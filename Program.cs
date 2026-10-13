using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.CompilerServices;
using static System.Console;



namespace banking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
           
            int money = 100000;
            int iron = 0;
            int cogwheels = 0;
            int day = 0;

            char choise = ' ';

            int workeramn = 0;
            int workerpay = 0;
            int workerhappy = 100;

            bool writen = true;

            Console.SetCursorPosition(0, 1);
            Console.WriteLine("PRESS: L for LOAN,  M for MARKET, B for BALANCE, H for HELP, S for STATS, C for CONFIGURE, A for PASS ONE DAY");


            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.Write(money);
                Console.SetCursorPosition(10, 0);
                Console.Write(iron);
                Console.SetCursorPosition(15, 0);
                Console.Write(workeramn);
                Console.SetCursorPosition(20, 0);
                Console.Write(cogwheels);
                Console.SetCursorPosition(25, 0);
                Console.Write(workerhappy);


                if (KeyAvailable)
                {
                    var input = Console.ReadKey(true);

                    //clears
                    if (writen == true)
                    {
                        for (int i = 0; i < 20; i++)
                        {
                            Console.SetCursorPosition(0, i + 4);
                            Console.WriteLine("                                                                                                                           ");
                        }
                    }
                    //clears

                    Console.SetCursorPosition(0, 4);
                    writen = false;

                    while(choise == 'B')
                    {
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
                            writen = true;
                        }
                    }

                    while(choise == 'L')
                    {
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
                            writen = true;
                        }
                    }

                    if (input.Key == ConsoleKey.H)
                    {
                    }
                    while(choise == 'H')
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
                        writen = true;
                    }

                    if (input.Key == ConsoleKey.M)
                    {
                        choise = 'M';
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
                    while (choise == 'M')
                    {
                        Console.SetCursorPosition(0, 0);
                        Console.Write(money);
                        Console.SetCursorPosition(10, 0);
                        Console.Write(iron);
                        Console.SetCursorPosition(15, 0);
                        Console.Write(workeramn);
                        Console.SetCursorPosition(20, 0);
                        Console.Write(cogwheels);
                        Console.SetCursorPosition(25, 0);
                        Console.Write(workerhappy);
                        var inputM = Console.ReadKey(true);
                        writen = true;
                        if (inputM.Key == ConsoleKey.Z)
                        {
                            iron++;
                            money -= 10;
                            writen = false;
                        }
                        if (inputM.Key == ConsoleKey.X)
                        {
                            workeramn++;
                            writen = false;
                        }
                        if (inputM.Key == ConsoleKey.C)
                        {
                            iron--;
                            money += 8;
                            writen = false;
                        }
                        if (inputM.Key == ConsoleKey.V)
                        {
                            cogwheels--;
                            money += 20;
                            writen = false;
                        }
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
                        writen = true;
                    }


                    if (input.Key == ConsoleKey.C)
                    {
                        Console.Write(
                            "\n" +
                            "CHANGE WORKER PAY : Z\n" +
                            "CHANGE WORK-HOURS\n" +
                            "\n"
                        );
                        writen = true;
                    }
                    if (input.Key == ConsoleKey.Z)
                    {

                        Console.Write("PAY $ : ");
                        workerpay = int.Parse(Console.ReadLine());
                        writen = true;
                    }

                    if (input.Key == ConsoleKey.A)
                    {
                        Console.Write(
                            "\n" +
                            "\n" +
                            "\n"
                        );
                        day++;
                        iron -= workeramn;
                        cogwheels += workeramn;
                        writen = true;

                        if (day % 30 == 0) 
                        {
                            money -= workerpay * workeramn; 
                            if (workerpay == 0)
                            {
                                money -= money / 5;
                            }
                        }
                        money -= (100 - workerhappy) * 1000;
                    }


                }
            }
        }
    }
}