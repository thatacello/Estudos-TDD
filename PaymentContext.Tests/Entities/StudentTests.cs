namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            var student = new Student("Bob", "Brown", "123456123", "bob@gmail.com");
            student.FirstName = "";
        }
        public void AdicionarAssinatura()
        {
            var subscription = new Subscription();
            var student = new Student("Bob", "Brown", "123456123", "bob@gmail.com");
            // student.Subscription.Add(subscription); // -> para impedir que isso aconteça, utilizar IReadOnlyCollection, então será obrigado a usar o AddSubscription
            student.AddSubscription(subscription);
        }
    }
}