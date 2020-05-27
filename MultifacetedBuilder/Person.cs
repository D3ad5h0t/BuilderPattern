namespace MultifacetedBuilder
{
    public class Person
    {
        // Address
        public string StreetAddress;
        public string Postcode;
        public string City;

        // Employment info
        public string CompanyName;
        public string Position;
        public int AnnualIncome;

        public override string ToString() => $"{nameof(StreetAddress)}: {StreetAddress}, " +
                                             $"{nameof(Postcode)}: {Postcode}, " +
                                             $"{nameof(City)}: {City}, " +
                                             $"{nameof(CompanyName)}: {CompanyName}, " +
                                             $"{nameof(Position)}: {Position}, " +
                                             $"{nameof(AnnualIncome)}: {AnnualIncome}";
    }
}