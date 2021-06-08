using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Tests.ValueObjects
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor -> testes 

        [TestMethod]
        public void Should_Return_Error_When_CNPJ_Is_Invalid()
        {
            var doc = new Document("123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid); // -> green
           // Assert.Fail(); // -> red
        }

        [TestMethod]
        public void Should_Return_Success_When_CNPJ_Is_Valid()
        {
            var doc = new Document("34110468000150", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
            // Assert.Fail();
        }

        [TestMethod]
        public void Should_Return_Error_When_CPF_Is_Invalid()
        {
            var doc = new Document("123", EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
            // Assert.Fail();
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("54960344008")]
        [DataRow("85672566073")]
        [DataRow("30158023056")]
        public void Should_Return_Success_When_CPF_Is_Valid(string cpf)
        {
            var doc = new Document(cpf, EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
            // Assert.Fail();
        }
    }
}