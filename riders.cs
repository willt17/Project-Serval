namespace Project_Serval
{
    public class riders
    {
        private string riderNumber;
        private string firstName;
        private string lastName;
        private string riderClass;
        private string transponderNumber;
        static private int count;
        public riders()
        {

        }
        public riders(string name1, string name2, string number, string inputClass, string transponderInput)
        {
            this.firstName = name1;
            this.lastName = name2;
            this.riderNumber = number;
            this.riderClass = inputClass;
            this.transponderNumber = transponderInput;
        }
        public void SetriderNumber(string number)
        {
            riderNumber = number;
        }
        public string GetRiderNumber()
        {
            return riderNumber;
        }
        public void SetFirstName(string name)
        {
            firstName = name;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public void SetLastName(string name)
        {
            lastName = name;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public void SetRiderClass(string userClass)
        {
            riderClass = userClass;
        }
        public string GetRiderClass()
        {
            return riderClass;
        }

        static public void SetCount(int temp)
        {
            count = temp;
        }
        static public int GetCount()
        {
            return count;
        }
        static public void IncCount()
        {
            count++;
        }
        public override string ToString()
        {
            return $"First name: {this.firstName} Last name: {this.lastName} Number: {this.riderNumber} Class: {this.riderClass}";
        }
        public string GetTransponderNumber()
        {
            string outputString = this.transponderNumber;
            return outputString;
        }
        public void SetTransponderNumber(string inputNumber)
        {
            this.transponderNumber = inputNumber;
        }
        public static int RiderSearch(string transponderNumber, riders[] thisRace)
        {
            int count = -1;
            for (int i = 0; i < riders.GetCount(); i++)
            {
                if (transponderNumber == thisRace[i].GetRiderNumber())
                {
                    count = i;
                }
            }
            return count;
        }





    }
}