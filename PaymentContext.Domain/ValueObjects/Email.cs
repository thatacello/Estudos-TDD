namespace PaymentContext.Domain.ValueObjects
{
    public class Email
    {
        public string Adress { get; set; }
        public Email(string adress)
        {
            Adress = adress;
        }
    }
}