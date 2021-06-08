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

            // contract -> não precisa testar, ele já testa para vc
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "Nome deve conter pelo menos 3 caracteres")
                .HasMinLen(LastName, 3, "Name.LastName", "Sobrenome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 40, "Name.FirstName", "Nome deve conter até 40 caracteres")
            );
        }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
    }
}