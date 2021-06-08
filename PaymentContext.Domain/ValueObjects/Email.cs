using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public string Adress { get; set; }
        public Email(string adress)
        {
            Adress = adress;
        }
    }
}