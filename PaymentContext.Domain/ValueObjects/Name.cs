using Flunt.Validations;
using PaymentContext.Shared.ValueObject;

namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            // não é necessário testar várias vezes, basta usar o flunt
            // if(string.IsNullOrEmpty(FirstName))
            //     AddNotification("Name.FirstName", "Nome inválido!");

            // if(string.IsNullOrEmpty(LastName))
            //     AddNotification("Name.FirstName", "Sobrenome inválido!");
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}