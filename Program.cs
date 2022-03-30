using System;
using System.IO;

namespace Project_Serval
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] riderNumbers = new string[999];
            string[] riderNames = new string[999];
            DateTime startTime = CurrTime();
            Console.ReadKey();
            System.Console.WriteLine("");
            DateTime lapOne = CurrTime();
            // TimeSpan timeElapsed = (lapOne - startTime);
            TimeSpan timeElapsed = TimeDiff(lapOne, startTime);
            System.Console.WriteLine($"Your first lap took {timeElapsed}");
            Console.ReadKey();
            DateTime lapTwo = CurrTime();
            timeElapsed = TimeDiff(lapTwo, lapOne);
            System.Console.WriteLine($"Your second lap took {timeElapsed}");
        }
        static void ImportRiders(string[] riderNumbers, string[] riderNames)
        {
            int count = 0;
            StreamReader inFile = new StreamReader("testFile.Txt");
            string[] temp = new string[2];
            string line = inFile.ReadLine();
            while (line != null)
            {
                temp = line.Split("#");
                riderNumbers[count] = temp[0];
                riderNames[count] = temp[1];
                line = inFile.ReadLine();
                count++;
            }
        }
        static DateTime CurrTime()
        {
            DateTime curr = DateTime.Now;
            string nowTime = curr.ToString();
            // int intTime = int.Parse(curr);
            // System.Console.WriteLine(nowTime);
            return curr;
        }
        static TimeSpan TimeDiff(DateTime x, DateTime y) // pass the older time first and the newer time second
        {
            TimeSpan timeElapsed = (x - y);
            // System.Console.WriteLine($"Your first lap took {timeElapsed}");
            return timeElapsed;
        }
        static void MenuMethod()
        {
            MenuText();
            string userInput = Console.ReadLine();
            while (userInput != "4")
            {
                if (userInput == "1")
                {
                    AddRider();
                    MenuText();
                    userInput = Console.ReadLine();
                }
                else if (userInput == "2")
                {
                    AddLap();
                    MenuText();
                    userInput = Console.ReadLine();
                }
                else if (userInput == "3")
                {
                    DisplayScoring();
                    MenuText();
                    userInput = Console.ReadLine();
                }

            }
        }
        static void MenuText()
        {
            System.Console.WriteLine("Stub for the menu text method.");
        }
        static void AddRider()
        {
            System.Console.WriteLine("Stub for the add rider method.");
        }
        static void AddLap()
        {
            System.Console.WriteLine("Stub for the add lap method.");
        }
        static void DisplayScoring()
        {
            System.Console.WriteLine("stub for the display scoring method.");
        }
    }
}
