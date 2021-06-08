using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Tests.Mocks;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        [TestMethod]
        public void Should_Return_Error_When_Document_Exists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Bruce";
            command.LastName = "Wayne";
            command.Document = "999999999";
            command.BarCode = "hello@gmail.com";
            command.BoletoNumber = "123456789";
            command.PaymentNumber = "123456789";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "Weyne Corp";
            command.PayerDocument = "12345678911";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "batman@gmail.com";
            command.Street = "asd";
            command.Number = "asd";
            command.Neighborhood = "asdasd";
            command.City = "asasd";
            command.State = "asdasd";
            command.Country = "asdasd";
            command.ZipCode = "12345678";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }

        // [TestMethod]
        // public void Should_Return_Success_When_CNPJ_Is_Valid()
        // {
            
        // }

        // [TestMethod]
        // public void Should_Return_Error_When_CPF_Is_Invalid()
        // {
           
        // }
    }
}