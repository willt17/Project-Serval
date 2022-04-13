namespace Project_Serval
{
    public class riders
    {
        private string riderNumber;
        private string firstName;
        private string lastName;
        private string riderClass;
        static private int count = 0;
        public riders()
        {

        }
        public riders(string name1, string name2, string number, string inputClass)
        {
            this.firstName = name1;
            this.lastName = name2;
            this.riderNumber = number;
            this.riderClass = inputClass;
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
        static public int GetCount()
        {
            return count;
        }
        static public void IncCount()
        {
            count++;
        }





    }
}