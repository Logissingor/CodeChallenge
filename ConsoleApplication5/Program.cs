using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            string dord = "language";
            UserInfoGrabber();
            mainMenu();
                      
        }
        static void mainMenu()
        {
            string input;
            Console.WriteLine(" ");
            Console.WriteLine("                   Welcome to the Hair Care Factory Database!");
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("  Please choose the kinds of services your client requires. Use the number keys\n  to do so.");
            Console.WriteLine(" ");
            Console.WriteLine("  0 - Standard Services");
            Console.WriteLine("  1 - Trim Services");
            Console.WriteLine("  2 - Nail Services");
            Console.WriteLine("  3 - Finalization");
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            input = Console.ReadLine();
            switch (input)
            {
                case "0":
                    Console.Clear();
                    standardStuff();
                    break;
                case "1":
                    Console.Clear();
                    trimm();
                    break;
                case "2":
                    Console.Clear();
                    talons();
                    break;
                case "3":
                    Console.Clear();
                    end();
                    break;
                default:
                    Console.WriteLine("Err- incorrect input Resetting...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    mainMenu();
                    break;
            }
        }
        static void standardStuff()
        {
            string[] standardPay;
            double timeFactor = 0;
            double firstInt = 0;
            double lastInt = 0;
            double costStand = 0;
            double cost1 = 0;
            double cost2 = 0;
            double cost3 = 0;
            double timeStand = 0;
            double timeTodd = 0;
            double timeTodd2 = 0;
            double timeTodd3 = 0;
            Console.WriteLine(" ");
            Console.WriteLine("                             Standard Services");
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("  Choose the desired number of these three options by inputting the option \n  number followed by the desired number, delineated by a space.\n    To exit, input \"exit\".");
            Console.WriteLine(" ");
            Console.WriteLine("  0 - Ladies' Standard Cut: Wash, haircut & blow-dry. $29.99. 1 hr.");
            Console.WriteLine("  1 - Men's Standard Cut: Wash, haircut & blow-dry. $19.99. 0.45 hr.");
            Console.WriteLine("  2 - Kid's Standard Cut: Wash, haircut & blow-dry. 12.99. 0.65 hr.");
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            string inpot = Console.ReadLine();
            standardPay = inpot.Split(' ');
            var first = standardPay.First();
            var last = standardPay.Last();
            string lastSt = last.ToString();
            string firstSt = first.ToString();
            if (lastSt != "exit") { lastInt = Convert.ToDouble(lastSt); }
            if (firstSt != "exit") { firstInt = Convert.ToDouble(firstSt); }
            switch (first.ToString())
            {
                case "0":
                    cost1 = lastInt * 29.99;
                    timeFactor = 1.0;
                    timeTodd = firstInt * timeFactor * 60;
                    Console.Clear();
                    standardStuff();
                    break;
                case "1":
                    cost2 = lastInt * 19.99;
                    timeFactor = 0.45;
                    timeTodd2 = firstInt * timeFactor * 60;
                    Console.Clear();
                   standardStuff();
                    break;
                case "2":
                    cost3 = lastInt * 12.99;
                    timeFactor = .65;
                    timeTodd3 = firstInt * timeFactor * 60;
                    Console.Clear();
                   standardStuff();
                    break;
                case "exit":
                    costStand = cost1 + cost2 + cost3;
                    timeStand = timeTodd + timeTodd2 + timeTodd3;
                    mainMenu();
                    break;
                default:
                    Console.WriteLine("Err- incorrect input Resetting...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    standardStuff();
                    break;

            }
        }
        static void trimm()
        {
            string[] trimmPay;
            double timeFactor = 0;
            double firstInt;
            double lastInt;
            double costTrimm;
            double cost1 = 0;
            double cost2 = 0;
            double cost3 = 0;
            double timeTrimm = 0;
            double timeTodd = 0;
            double timeTodd2 = 0;
            double timeTodd3 = 0;
            Console.WriteLine(" ");
            Console.WriteLine("                                  Trim Services");
            Console.WriteLine(" ");
            Console.WriteLine("--------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("  Choose the desired number of these three options by inputting the option \n  number followed by the desired number, delineated by a space.\n    To exit, input \"exit\".");
            Console.WriteLine(" ");
            Console.WriteLine("  0 - Ladies/Girl's Bangs Trim: Cutting of bangs only. $7.99. 0.35 hr. ");
            Console.WriteLine("  1 - Men's Trim: Trim of sideburns, neck, and glabella. $9.99. 0.25 hr.");
            Console.WriteLine("--------------------------------------------------------------------------------");
            trimmPay = Console.ReadLine().Split(' ');
            var first = trimmPay.First();
            var last = trimmPay.Last();
            string lastSt = last.ToString();
            string firstSt = first.ToString();
            lastInt = Convert.ToDouble(lastSt);
            firstInt = Convert.ToDouble(firstSt);
            switch (first.ToString())
            {
                case "0":
                    cost1 = lastInt * 7.99;
                    timeFactor = 0.35;
                    timeTodd = firstInt * timeFactor * 60;
                    Console.Clear();
                    trimm();
                    break;
                case "1":
                    cost2 = lastInt * 9.99;
                    timeFactor = 0.25;
                    timeTodd2 = firstInt * timeFactor * 60;
                    Console.Clear();
                    trimm();
                    break;
                case "exit":
                    costTrimm = cost1 + cost2;
                    timeTrimm = timeTodd + timeTodd2;
                    mainMenu();
                    break;
                default:
                    Console.WriteLine("Err- incorrect input Resetting...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    trimm();
                    break;
            }
        }
        static void talons()
        {

        }
        static void UserInfoGrabber()
        {
            Console.WriteLine("Welcome to the Hair Care Factory Database.");
            Console.WriteLine("Please enter the client's first and last names deliniated by a single space.");
            var line = Console.ReadLine();
            ValueStorage.name = line.Split(' ');
            Console.WriteLine("Please enter the client's e-mail address.");
            ValueStorage.em = Console.ReadLine();
            Console.WriteLine("Please enter the client's phone number.");
            ValueStorage.pn = Console.ReadLine();
            Console.WriteLine("Is this a mobile phone number? (y/n)");
            if (Console.ReadLine() == "y")
            {
                ValueStorage.mobile = true;
            }
            
            Console.WriteLine("Thank you. One moment please.");
            Thread.Sleep(1500);
            Console.Clear();
        }
        static void end()
        {

        }

    }
    class ValueStorage
    {
            //gets and stores user info
            public static string[] name;
            public static string em;
            public static string pn;
            public static bool mobile;
        
    }
}
