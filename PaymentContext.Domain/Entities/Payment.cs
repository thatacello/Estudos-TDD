namespace PaymentContext.Domain.Entities
{
    public abstract class Payment // abstrato -> não posso instanciar essa classe
    {
        public string Number { get; set; }
        public DateTime PaidDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; }
        public string Document { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }

    }
    public class BoletoPayment : Payment
    {
        public string BarCode { get; set; } // código de barras
        public string BoletoNumber { get; set; }
    }
    public class CreditCardPayment : Payment
    {
        public string CardHolderName { get; set; }
        public string CardNumber { get; set; }
        public string LastTransactionNumber { get; set; }
    }
    public class PayPalPayment : Payment // só precisa do e-mail
    {
        public string TransactionCode { get; set; }
    }
}