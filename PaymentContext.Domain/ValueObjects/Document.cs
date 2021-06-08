namespace PaymentContext.Domain.ValueObjects
{
    public class Document
    {
        public string Number { get; private set; }
        public EDocumentType Type { get; set; }
        public Document(string number, EDocumentType type)
        {
            Number = number;
            Type = type;
        }
    }
}