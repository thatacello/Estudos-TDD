using System.Collections.Generic;
using PaymentContext.Shared.Entities;
using PaymentContext.Domain.ValueObjects;
using System.Linq;
using Flunt.Validations;

namespace PaymentContext.Domain.Entities
{
    public class Student : Entity
    {
        private IList<Subscription> _subscriptions;
        public Student(Name name, Document document, Email email)
        {
            Name = name;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();

            AddNotifications(name, document, email);
        }
        public Name Name { get; private set; } // private -> só posso mudar o FirstName dentro da classe Studant
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public Address Adress { get; private set; }
        public IReadOnlyCollection<Subscription> Subscriptions { get{ return _subscriptions.ToArray(); } }

        public void AddSubscription(Subscription subscription)
        {
            var hasSubscriptionActive = false;
            foreach(var sub in _subscriptions)
            {
                if (sub.Active)
                    hasSubscriptionActive = true;
            }

            AddNotifications(new Contract()
                .Requires()
                .IsFalse(hasSubscriptionActive, "Student.Subscriptions", "Você já tem uma assinatura ativa")
            );

            // alternativa
            if(hasSubscriptionActive)
                AddNotification("Student.Subscriptions", "Você já tem uma assinatura ativa");

            // se já tiver uma assinatura ativa, cancela
            
            // cancela todas as outras assinaturas e como coloca esta como principal
            // foreach(var sub in Subscriptions)
            // {
            //     sub.Inactivate();
            // }

            // _subscriptions.Add(subscription);
        }
    }
}