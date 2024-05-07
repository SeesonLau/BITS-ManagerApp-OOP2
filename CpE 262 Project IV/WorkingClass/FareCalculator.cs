
namespace CpE_262_Project_IV
{
    public class FareCalculator : DeclarationProperties
    {
        private double? fare;
        public double? GetFare() { return fare; }
        protected void SetFare(double? fare) { this.fare = fare; }
        public double CalculateFare(double? initial, double? final, string passengerType, string busType)
        {
            Directory directory = new Directory();
            TrueDistance dis = new TrueDistance();
            PassengerType pass = new PassengerType();

            FareDeclaration(busType);

            var passenger = pass.GetPassengerType(passengerType);
            double? totalFare, trueFare;

            double? distanceBelowkm;

            double? trueDistance = GetTrueDistance(initial, final);

            if (trueDistance <= 5)
            {
                totalFare = GetRegularFare();
            }
            else
            {
                distanceBelowkm = trueDistance - 5;
                totalFare = GetRegularFare() + (distanceBelowkm * GetRegularRate());
            }
            if (passenger != "Regular")
            {
                trueFare = totalFare - (totalFare * GetDiscount());
            }
            else
            {
                trueFare = totalFare;
            }
            SetFare(trueFare);
            return trueFare ?? 0;
        }
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
