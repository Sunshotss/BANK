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
    class Worker
    {
        public int pay = 0;
        public int happiness = 100;
        public string name = "jonathan";
        public Worker(int pay, int happynes, string name)
        {
            this.pay = pay;
            this.happiness = happynes;
            this.name = name;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            ConsoleKeyInfo input = new();

            List<Worker> recruits = new List<Worker>();
            recruits.Add(new Worker(15, 100, "jacob"));
            recruits.Add(new Worker(23,28,"samuel"));
            recruits.Add(new Worker(20, 56, "elias"));

            List<Worker> employees = new List<Worker>();

            int money = 100000;
            int iron = 0;
            int cogwheels = 0;
            int day = 0;


            bool gameon = true;

            void Day(ref int money, ref int iron, ref int cogwheels, ref int day)
            {
                Console.Write(
                    "\n" +
                    "\n" +
                    "\n"
                );
                day++;

                foreach (Worker employee in employees)
                {
                    iron--;
                    cogwheels++;

                    employee.happiness--;

                    if (day % 30 == 0) 
                    {
                        money -= employee.pay;
                    }
                    //money -= (100 - employee.happiness);
                }
            }

            void Market(ref ConsoleKeyInfo input, ref int money, ref int iron, ref int cogwheels, ref List<Worker> recruits)
            {

                if (input.Key == ConsoleKey.M)
                {
                    Console.Write(
                        "\n" +
                        $"BALANCE: {money}\n" +
                        "Z : 10 iron\n" +
                        "price : 10$\n" +
                        "arrow up / arrow down selects worker to purchase\n" +
                        "X : buy worker worker\n" +
                        "C : 10 iron sold\n" +
                        "V : 10 cogwheel sold\n" +
                        "worker cost for upkeep : 1 iron, produces : 1 gear : 20$\n" +
                        "\n" +
                        "recruits:\n"
                    );
                    for (int i = 0; i < recruits.Count; i++)
                    {
                        Console.Write($"{i + 1}. ");
                        Console.WriteLine(recruits[i].name + "  pay: " + recruits[i].pay);
                    }
                }
                if (input.Key == ConsoleKey.Z)
                {
                    iron += 10;
                    money -= 100;
                }


                int selected = 2;
                if (input.Key == ConsoleKey.DownArrow)
                {
                    selected++;
                }
                if (input.Key == ConsoleKey.UpArrow)
                {
                    selected--;
                }
                if (input.Key == ConsoleKey.X)
                {
                    employees.Add(recruits[selected]);
                    Console.SetCursorPosition(0, 20);
                    Console.WriteLine("current employees:");
                    for (int i = 0; i < employees.Count; i++)
                    {
                        Console.WriteLine(employees[i].name + "  pay: " + employees[i].pay);
                    }
                }


                if (input.Key == ConsoleKey.C)
                {
                    iron -= 10;
                    money += 80;
                }
                if (input.Key == ConsoleKey.V)
                {
                    cogwheels -= 10;
                    money += 200;
                }
            }

            void Startup(int money, int iron, int cogwheels, int day)
            {
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("PRESS: L for LOAN,  M for MARKET, H for HELP, C for WAGES, A for PASS ONE DAY");
                Console.SetCursorPosition(0, 0);
                Console.Write("$ " + money);
                Console.SetCursorPosition(20, 0);
                Console.Write("iron: " + iron);
                Console.SetCursorPosition(30, 0);
                Console.Write("cogs: " + cogwheels);
                Console.SetCursorPosition(40, 0);
                Console.Write("day: " + day);
            }

            void Help()
            {
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

            }



            /*

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

           */

            int option = 0;

            while (gameon)
            {
                //shows stats and important stuff on start
                Startup(money, iron, cogwheels, day);
                //show stats and important stuff on start

                Console.SetCursorPosition(0, 4);
                if (KeyAvailable)
                {
                    input = Console.ReadKey(true);

                    //czech option
                    if (input.Key == ConsoleKey.M)
                    {
                        option = 1;
                    }
                    if (input.Key == ConsoleKey.A)
                    {
                        Day(ref money, ref iron, ref cogwheels, ref day);
                    }
                    if (input.Key == ConsoleKey.H)
                    {
                        Help();
                    }
                    if (input.Key == ConsoleKey.Escape) 
                    { 
                        option = 0; 
                        Console.Clear(); 
                    }
                    //czech option


                    //options
                    if (option == 1)
                    {
                        Market(ref input, ref money, ref iron, ref cogwheels, ref recruits);
                    }
                    //options
                }


            }

        }
    }
}