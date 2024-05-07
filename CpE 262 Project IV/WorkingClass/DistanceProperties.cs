namespace CpE_262_Project_IV
{
    //USE this if DATABASE CONNECTION IS SEVERED
    interface Barangay
    {
        string GetBoardingBarangay();
        string GetDestinationBarangay();
    }
    interface interfaceFare
    {
        double GetThisFare();
    }
    interface Distance
    {
        double GetDistanceBoarding();
        double GetDistanceDestination();
        double GetDistance();
    }
    public abstract class DistanceProperties : DeclarationProperties, Barangay, Distance
    {
        public abstract string GetBoardingBarangay();
        public abstract string GetDestinationBarangay();
        public abstract double GetDistanceBoarding();
        public abstract double GetDistanceDestination();
        public abstract double GetDistance();
    }
    public class Location : DistanceProperties
    {

        public override string GetBoardingBarangay()
        {
            Admin form = new Admin();
            return "yes";        }
        public override string GetDestinationBarangay()
        {
            return "yes";
        }
        public override double GetDistanceBoarding()
        {
            switch (GetBoardingBarangay())
            {
                //CEBU CITY
                case "Cebu South Bus Terminal":
                    return 0;
                case "Cebu Institute of Technology University":
                    return 1.4;
                case "Basak San Nicolas":
                    return 3.58;
                case "Cogon Pardo":
                    return 4.87;
                case "Bulacao":
                    return 6.4;
                //TALISAY
                case "Tabunok":
                    return 6.87;
                case "Lawaan":
                    return 8.46;
                case "Linao":
                    return 9.21;
                //MINGLANILLA
                case "Tungkil":
                    return 10.8;
                case "Calajo-an":
                    return 12.6;
                case "Tulay":
                    return 13.2;
                case "Tungkop":
                    return 14.2;
                //NAGA
                case "Inayagan":
                    return 15.2;
                case "Tuyan":
                    return 16.4;
                case "Colon":
                    return 17.4;
                case "Naga City":
                    return 18.9;
                case "Tinaan":
                    return 19.2;
                case "Inoburan":
                    return 20.2;
                case "Langtad Naga":
                    return 22.2;
                //SAN FERNANDO
                case "Pitalo":
                    return 24.3;
                case "San Isidro":
                    return 25.1;
                case "San Fernando Municipal Hall":
                    return 26.5;
                case "Balud":
                    return 28.6;
                case "Sangat":
                    return 30.5;
                //CARCAR
                case "Perrelos":
                    return 33.1;
                case "Carcar Gaisano Grand Mall":
                    return 36.5;
                case "Rotonda":
                    return 37.5;
                case "Bolinawan":
                    return 40;
                case "Ocana":
                    return 42;
                //SIBONGA
                case "Abugon":
                    return 43;
                case "Candaguit":
                    return 44.6;
                case "Sabang":
                    return 45.9;
                case "Sibonga Municipal Hall":
                    return 47.7;
                case "Bahay":
                    return 50;
                case "Simala":
                    return 53.2;
                //ARGAO
                case "Bulasa":
                    return 58.3;
                case "Binlod":
                    return 60;
                case "Langtad":
                    return 62.9;
                case "Tulic":
                    return 66.7;
                case "Bogo":
                    return 68.8;
                case "Talaga":
                    return 70.1;
                case "Balisong":
                    return 72;
                //DALAGUETE
                case "Casay":
                    return 74.4;
                case "Cawayan":
                    return 76.9;
                case "Dalaguete Municipal Hall":
                    return 82.1;
                default:
                    return 0;
            }
        }
        public override double GetDistanceDestination()
        {
            switch (GetDestinationBarangay())
            {
                //CEBU CITY
                case "Cebu South Bus Terminal":
                    return 0;
                case "Cebu Institute of Technology University":
                    return 1.4;
                case "Basak San Nicolas":
                    return 3.58;
                case "Cogon Pardo":
                    return 4.87;
                case "Bulacao":
                    return 6.4;
                //TALISAY
                case "Tabunok":
                    return 6.87;
                case "Lawaan":
                    return 8.46;
                case "Linao":
                    return 9.21;
                //MINGLANILLA
                case "Tungkil":
                    return 10.8;
                case "Calajo-an":
                    return 12.6;
                case "Tulay":
                    return 13.2;
                case "Tungkop":
                    return 14.2;
                //NAGA
                case "Inayagan":
                    return 15.2;
                case "Tuyan":
                    return 16.4;
                case "Colon":
                    return 17.4;
                case "Naga City":
                    return 18.9;
                case "Tinaan":
                    return 19.2;
                case "Inoburan":
                    return 20.2;
                case "Langtad Naga":
                    return 22.2;
                //SAN FERNANDO
                case "Pitalo":
                    return 24.3;
                case "San Isidro":
                    return 25.1;
                case "San Fernando Municipal Hall":
                    return 26.5;
                case "Balud":
                    return 28.6;
                case "Sangat":
                    return 30.5;
                //CARCAR
                case "Perrelos":
                    return 33.1;
                case "Carcar Gaisano Grand Mall":
                    return 36.5;
                case "Rotonda":
                    return 37.5;
                case "Bolinawan":
                    return 40;
                case "Ocana":
                    return 42;
                //SIBONGA
                case "Abugon":
                    return 43;
                case "Candaguit":
                    return 44.6;
                case "Sabang":
                    return 45.9;
                case "Sibonga Municipal Hall":
                    return 47.7;
                case "Bahay":
                    return 50;
                case "Simala":
                    return 53.2;
                //ARGAO
                case "Bulasa":
                    return 58.3;
                case "Binlod":
                    return 60;
                case "Langtad":
                    return 62.9;
                case "Tulic":
                    return 66.7;
                case "Bogo":
                    return 68.8;
                case "Talaga":
                    return 70.1;
                case "Balisong":
                    return 72;
                //DALAGUETE
                case "Casay":
                    return 74.4;
                case "Cawayan":
                    return 76.9;
                case "Dalaguete Municipal Hall":
                    return 82.1;
                default:
                    return 0;
            }
        }
        public override double GetDistance()
        {
            double totalDistance = Math.Abs(GetDistanceDestination() - GetDistanceBoarding());
            return totalDistance;
        }
    }
}
