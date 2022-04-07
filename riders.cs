namespace Project_Serval
{
    public class riders
    {
        private int riderNumber;
        private string firstName;
        private string lastName;
        private string riderClass;

        public void SetriderNumber(int riderNumber)
        {
            this.riderNumber = riderNumber;
        }
        public int GetRiderNumber()
        {
            return riderNumber;
        }
        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }
        public string GetFirstName()
        {
            return firstName;
        }
        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }
        public string GetLastName()
        {
            return lastName;
        }
        public void SetRiderClass(string riderClass)
        {
            this.riderClass = riderClass;
        }
        public string GetRiderClass()
        {
            return riderClass;
        }




    }
}