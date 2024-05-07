namespace CpE_262_Project_IV
{
    public class TrueDistance
    {
        public double? GetTrueDistance(double? initial, double? final)
        {
            double trueDistance = 0;
            if (initial.HasValue && final.HasValue)
            {
                trueDistance = Math.Abs(final.Value - initial.Value);
                return trueDistance;
            }
            return trueDistance;
        }
    }
}
