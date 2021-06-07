using System.Collections.Generic;
namespace PaymentContext.Domain.Entities
{
    public class Student
    {
        public Student(string firstName, string lastName, string document, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Document = document;
            Email = email;

            if(firstName.Length == 0)
                throw new Exception("Nome inválido!");
        }
        public string FirstName { get; private set; } // private -> só posso mudar o FirstName dentro da classe Studant
        public string LastName { get; private set; }
        public string Document { get; private set; }
        public string Email { get; private set; }
        public string Adress { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get; private set; }

        public void AddSubscription(Subscription subscription)
        {
            // se já tiver uma assinatura ativa, cancela

            // cancela todas as outras assinaturas e como coloca esta como principal
            foreach(var sub in Subscription)
            {
                sub.Active = false;
            }

            Subscription.Add(subscription);
        }
    }
}