namespace CpE_262_Project_IV
{
    //File Handling to Pass Datas
    public class InitializePassDrive
    {
        public string? RetrievePassID()
        {
            string content = File.ReadAllText("PassengerIDSET.txt");
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
