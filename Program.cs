﻿using System;
using System.IO;

namespace Project_Serval
{
    class Program
    {
        static void Main(string[] args)
        {
            riders[] currentRace = new riders[999];
            // DateTime startTime = CurrTime();
            // Console.ReadKey();
            // System.Console.WriteLine("");
            // DateTime lapOne = CurrTime();
            // TimeSpan timeElapsed = (lapOne - startTime);
            // TimeSpan timeElapsed = TimeDiff(lapOne, startTime);
            // System.Console.WriteLine($"Your first lap took {timeElapsed}");
            // Console.ReadKey();
            // DateTime lapTwo = CurrTime();
            // timeElapsed = TimeDiff(lapTwo, lapOne);
            // System.Console.WriteLine($"Your second lap took {timeElapsed}");
            MenuMethod(currentRace);
        }
        static void ImportRiders(riders[] currentRace)
        {
            int count = 0;
            StreamReader inFile = new StreamReader("testFile.Txt");
            string[] temp = new string[2];
            string line = inFile.ReadLine();
            while (line != null)
            {
                temp = line.Split("#");
                // string tempFirstName = temp[0];
                // string TempLastName = temp[1];
                // string tempRiderNumber = temp[2];
                // string tempRiderClass = temp[3];
                currentRace[count].SetFirstName(temp[0]);
                currentRace[count].SetFirstName(temp[1]);
                currentRace[count].SetriderNumber(temp[2]);
                currentRace[count].SetRiderClass(temp[3]);
                line = inFile.ReadLine();
                count++;
            }
            inFile.Close();
            TestRead(currentRace, count);
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
        static void MenuMethod(riders[] currentRace)
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
                    // AddLap();
                    // MenuText();
                    ImportRiders(currentRace);
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
            System.Console.WriteLine("Press 1 to add a rider, Press 2 to import riders from file.");
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
        static void TestRead(riders[] currentRace, int count)
        {
            for (int i = 0; i < count; i++)
            {
                System.Console.WriteLine($"first name is {currentRace[i].GetFirstName()}");
            }
        }
    }
}
