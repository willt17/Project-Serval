using System;
using System.IO;

namespace Project_Serval
{
    class Program
    {
        static void Main(string[] args)
        {
            riders[] currentRace = new riders[999];
            Laps[] thisRace = new Laps[999];
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
            MenuMethod(currentRace, thisRace);
        }
        static void ImportRiders(riders[] currentRace)
        {
            // int count = 0;
            riders.SetCount(0);
            StreamReader inFile = new StreamReader("testFile.Txt");
            string line = inFile.ReadLine();
            while (line != null)
            {
                string[] temp = line.Split("#");
                // string tempFirstName = temp[0];
                // string TempLastName = temp[1];
                // string tempRiderNumber = temp[2];
                // string tempRiderClass = temp[3];
                // System.Console.WriteLine(currentRace[0]);
                // System.Console.WriteLine(temp[0]);
                System.Console.WriteLine($"{temp[0]} {temp[1]} {temp[2]} {temp[3]}");
                currentRace[riders.GetCount()] = new riders();
                currentRace[riders.GetCount()].SetFirstName(temp[0]);
                currentRace[riders.GetCount()].SetLastName(temp[1]);
                currentRace[riders.GetCount()].SetriderNumber(temp[2]);
                currentRace[riders.GetCount()].SetRiderClass(temp[3]);
                //currentRace[riders.GetCount()].SetTransponderNumber(temp[4]);
                line = inFile.ReadLine();
                riders.IncCount();
            }
            inFile.Close();
            // TestRead(currentRace, riders.GetCount());
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
        static void MenuMethod(riders[] currentRace, Laps[] thisRace)
        {
            DateTime raceStartTime = CurrTime();
            MenuText();
            string userInput = Console.ReadLine();
            while (userInput != "9")
            {
                if (userInput == "1")
                {
                    AddRider(currentRace);
                    MenuText();
                    userInput = Console.ReadLine();
                }
                else if (userInput == "2")
                {
                    // AddLap();
                    // MenuText();
                    ImportRiders(currentRace);
                    MenuText();
                    userInput = Console.ReadLine();
                }
                else if (userInput == "3")
                {
                    DisplayScoring(raceStartTime, currentRace, thisRace);
                    MenuText();
                    userInput = Console.ReadLine();
                }
                else if (userInput == "4")
                {
                    raceStartTime = StartRace();
                    MenuText();
                    userInput = Console.ReadLine();
                }
                else if (userInput == "5")
                {
                    TestToString(currentRace);
                    MenuText();
                    userInput = Console.ReadLine();
                }

            }
        }
        static void MenuText()
        {
            System.Console.WriteLine("Press 1 to add a rider, Press 2 to import riders from file.");
            System.Console.WriteLine("Press 3 to enter scoring mode, press 4 to start a new race.");
        }
        static void AddRider(riders[] currentRace)
        {
            System.Console.WriteLine("Stub for the add rider method.");
            System.Console.WriteLine("Input first name.");
            string inputName = Console.ReadLine();
            System.Console.WriteLine("Input last name");
            string inputLastName = Console.ReadLine();
            System.Console.WriteLine("Enter number.");
            string inputNumber = Console.ReadLine();
            System.Console.WriteLine("Enter class.");
            string inputClass = Console.ReadLine();
            System.Console.WriteLine("Please scan the riders transponder.");
            string transponderInput = Console.ReadLine();
            currentRace[riders.GetCount()] = new riders(inputName, inputLastName, inputNumber, inputClass, transponderInput);
            riders.IncCount();
            arraySave(currentRace);
        }
        static void AddLap()
        {
            System.Console.WriteLine("Stub for the add lap method.");
        }
        static void DisplayScoring(DateTime raceStartTime, riders[] currentRace, Laps[] thisRace)
        {
            System.Console.WriteLine("Have You run the Race Start function? If so press 1, or press 2 to do it now.");
            string userInput = Console.ReadLine();
            if (userInput == "1")
            {
                OngoingRace(raceStartTime, currentRace, thisRace);
            }
            else if (userInput == "2")
            {
                raceStartTime = StartRace();
                OngoingRace(raceStartTime, currentRace, thisRace);
            }
        }
        static void TestRead(riders[] currentRace, int count)
        {
            for (int i = 0; i < count; i++)
            {
                System.Console.Write(currentRace[i].GetFirstName() + " ");
                System.Console.Write(currentRace[i].GetLastName() + " ");
                System.Console.Write(currentRace[i].GetRiderNumber() + " ");
                System.Console.Write(currentRace[i].GetRiderClass());
                System.Console.WriteLine(" ");
            }
        }
        static void arraySave(riders[] currentRace)
        {
            StreamWriter outFile = new StreamWriter("testFile.txt");
            string outputLine = $"{currentRace[0].GetFirstName()}#{currentRace[0].GetLastName()}#{currentRace[0].GetRiderNumber()}#{currentRace[0].GetRiderClass()}";
            outFile.WriteLine(outputLine);
            for (int i = 1; i < riders.GetCount(); i++)
            {
                outputLine = $"{currentRace[i].GetFirstName()}#{currentRace[i].GetLastName()}#{currentRace[i].GetRiderNumber()}#{currentRace[i].GetRiderClass()}";
                outFile.WriteLine(outputLine);
            }
            outFile.Close();
        }
        static DateTime StartRace()
        {
            DateTime raceStartTime = CurrTime();
            System.Console.WriteLine($"Your race has been started at {raceStartTime}.");
            return raceStartTime;
        }
        static void TestToString(riders[] currentRace)
        {
            System.Console.WriteLine("Please scan the riders transponder.");
            string searchVal = Console.ReadLine();
            int currentRider = SearchFunction(searchVal, currentRace);
            if (currentRider == -1)
            {
                System.Console.WriteLine("That rider is not entered in this race.");
            }
            else
            {
                currentRace[currentRider].ToString();
            }
        }
        static int SearchFunction(string searchVal, riders[] currentRace)
        {
            int arraySpot = -1;
            for (int i = 0; i < riders.GetCount(); i++)
            {
                if (searchVal == currentRace[i].GetTransponderNumber())
                {
                    arraySpot = i;
                }
            }
            return arraySpot;

        }
        static void OngoingRace(DateTime raceStartTime, riders[] currentRace, Laps[] thisRace)
        {
            string value = "1";
            while (value != "stop")
            {
                System.Console.WriteLine("Scan riders transponders or type STOP to end.");
                value = Console.ReadLine();
                if (value.ToLower() == "stop")
                {
                    System.Console.WriteLine("This race has ended.");
                }
                else
                {
                    int placeholder = Laps.GetOverallLap() + 1;
                    int numberTemp = riders.RiderSearch(value, currentRace);
                    string localRiderNumber = currentRace[numberTemp].GetRiderNumber();
                    DateTime nowTime = CurrTime();
                    thisRace[placeholder] = new Laps(value, nowTime, thisRace);
                    Laps.IncOverallLaps();
                }
            }
        }
    }
}
