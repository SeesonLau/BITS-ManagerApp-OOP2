namespace CpE_262_Project_IV
{
    public class CallFile : DatabaseAccess
    {
        public string? RetrievePassID()
        {
            string content = File.ReadAllText("PassIDlogin.txt");
            return content;
        }
        public string? RetrieveBusType() 
        {
            string content = File.ReadAllText("DriverSETbustype.txt");
            return content;
        }
        public string? RetrieveDriverID()
        {
            string content = File.ReadAllText("DriverIDSET.txt");
            return content;
        }
    }
}
