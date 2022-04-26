using System;
using System.IO;
namespace Project_Serval
{
    public class Laps
    {
        private int lapNumber;
        private string riderNumber;
        private DateTime startTime;
        private DateTime endTime;
        private static int overallLaps = 0;
        public Laps(string numberInput, DateTime secondTime, Laps[] thisRace)
        {
            this.lapNumber = FindLap(numberInput, thisRace);
            this.riderNumber = numberInput;
            this.startTime = FindMostRecentLap(riderNumber, thisRace);
            this.endTime = secondTime;
        }
        public int GetLapNumber()
        {
            return this.lapNumber;
        }
        public void SetLapNumber(string riderNumberInput, Laps[] thisRace)
        {
            int currLap = (FindLap(riderNumberInput, thisRace ) + 1);
            lapNumber = currLap;
        }
        public int FindLap(string riderNumberInput, Laps[] thisRace)
        {
            int lapCount = 0;
            for (int i = 0; i < overallLaps; i++ )
            {
                if (thisRace[i].GetRiderNumber() == riderNumberInput)
                {
                    lapCount++;
                }
            }
            return lapCount;
        }
        public string GetRiderNumber()
        {
            return riderNumber;
        }
        public static int GetOverallLap()
        {
            return overallLaps;
        }
        public DateTime FindMostRecentLap(string riderNumber, Laps[] thisRace)
        {
            Laps[] temp = new Laps[99];
            int count = 0;
            for (int i = 0; i < GetOverallLap(); i++)
            {
                if (thisRace[i].GetRiderNumber() == riderNumber)
                {
                    temp[count] = thisRace[i];
                    count++;
                }
            }
            DateTime returnValue = TopLap(temp, count);
            return returnValue;
        }
        public DateTime TopLap(Laps[] temp, int count)
        {
            int maxLap = 0;
            for (int i = 0; i < count; i++)
            {
                if (temp[i].GetLapNumber() > maxLap)
                {
                    maxLap = temp[i].GetLapNumber();
                }
            }
            DateTime returnValue = temp[count].GetEndTime();
            return returnValue;
        }
        public DateTime GetEndTime()
        {
            return endTime;
        }
        public static void IncOverallLaps()
        {
            overallLaps++;
        }
    }
}