namespace Project_Serval
{
    public class riders
    {
        private int riderNumber;
        private string firstName;
        private string lastName;
        private string riderClass;
    }
    public riders RiderNumber
    {
        get { return RiderNumber; }
        set 
        { 
            RiderNumber = int.Parse(value);
        }
    }
}