using System.Reflection.Metadata;
using System.Collections.Generic;
namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;
        public Student(string Name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

            if(firstName.Length == 0)
                throw new Exception("Nome inválido!");
        }
        public Name Name { get; private set; } // private -> só posso mudar o FirstName dentro da classe Studant
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Adress { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get{ return _subscriptions.ToArray(); } }
    }
}