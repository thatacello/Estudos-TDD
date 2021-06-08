using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // var student = new Student("Bob", "Brown", "123456123", "bob@gmail.com");
            // student.FirstName = "";
        }
        public void AdicionarAssinatura()
        {
            // var subscription = new Subscription(null);
            // var student = new Student("Bob", "Brown", "123456123", "bob@gmail.com");
            // // student.Subscription.Add(subscription); // -> para impedir que isso aconteça, utilizar IReadOnlyCollection, então será obrigado a usar o AddSubscription
            // student.AddSubscription(subscription);
        }
        public void AddSubscription(Subscription subscription)
        {
            // se já tiver uma assinatura ativa, cancela

            // cancela todas as outras assinaturas e como coloca esta como principal
            // foreach(var sub in Subscription)
            // {
            //     sub.Inactivate();
            // }

            // _subscription.Add(subscription);
        }
    }
}