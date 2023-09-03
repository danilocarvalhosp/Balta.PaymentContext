using PaymentContext.Domain.Commands;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.ValueObjects;
using PaymentContext.Test.Mocks;

namespace PaymentContext.Test
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        // Red, Green, Refactor

        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = "Bruce";
            command.LastName = "Wayne";
            command.Document = "99999999999";
            command.Email = "hello@balta.io2";

            command.BarCode = "123456789";
            command.BoletoNumber = "1233221";
            command.PaymentNumber = "56659586";

            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "Wayne Corp";
            command.PayerDocument = "12345678911";
            command.PayerDocumentType = EDocumentType.CPF;
            command.Street = "asfd";
            command.Number = "asfd";
            command.Neighborhood = "asfd";
            command.City = "asfd";
            command.State = "asfd";
            command.Country = "asfd";
            command.ZipCode = "12345678";
            command.PayerEmail = "batman@dc.com";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}