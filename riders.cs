namespace Project_Serval
{
    public class riders
    {
        private int riderNumber;
        private string firstName;
        private string lastName;
        private string riderClass;
    }
    public int RiderNumber
    {
        get { return riderNumber; }
        set 
        { 
            RiderNumber = int.Parse(value);
        }
    }
}