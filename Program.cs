using System;

namespace Project_Serval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string[] riderNumbers = new string[999];
            string[] riderNames = new string[999];
        }
        static void ImportRiders(string[] riderNumbers, string[] riderNames)
        {
            int count = 0;
            StreamReader inFile = new StreamReader("testFile.Txt");
            string[] temp = inFile.ReadLine();
            while (temp != null)
            {
                riderNumbers[count] = temp[0];
                riderNames[count] = temp[1];
                temp = inFile.ReadLine();
                count++;
            }
        }
    }
}
