namespace CpE_262_Project_IV
{
    public class RandomID
    {
        private static readonly Random random = new Random();

        public static int GRNPassenger()
        {
            return random.Next(100000, 199999);
        }
        public static int GRNAdmin()
        {
            return random.Next(900000, 999999);
        }
        public static int GRNDriver()
        {
            return random.Next(800000, 899999);
        }
    }
}
