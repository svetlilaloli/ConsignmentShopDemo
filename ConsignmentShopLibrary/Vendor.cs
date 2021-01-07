namespace ConsignmentShopLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal PaymentDue { get; set; }
        public Vendor()
        {
            Commission = .5;
            PaymentDue = .0M;
        }
        public string Display
        {
            get
            {
                return string.Format("{0} {1} - ${2:f2}", FirstName, LastName, PaymentDue);
            }
        }
    }
}
