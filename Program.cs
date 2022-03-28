using System;
using System.IO;

namespace Project_Serval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] riderNumbers = new string[999];
            string[] riderNames = new string[999];
            DateTime startTime = CurrTime();
            Console.ReadKey();
            DateTime lapOne = CurrTime();
            TimeSpan timeElapsed = (lapOne - startTime);
            System.Console.WriteLine($"Your first lap took {timeElapsed}");
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
            System.Console.WriteLine(nowTime);
            return curr;
        }
    }
}
