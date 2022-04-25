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
        public Laps(string numberInput, DateTime firstTime, DateTime secondTime, Laps[] thisRace)
        {
            this.lapNumber = FindLap(numberInput, thisRace);
            this.riderNumber = numberInput;
            this.startTime = firstTime;
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
    }
}