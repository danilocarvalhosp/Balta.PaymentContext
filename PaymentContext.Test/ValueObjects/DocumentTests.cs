using PaymentContext.Domain.Enums;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Test
{
    [TestClass]
    public class DocumentTests
    {
        // Red, Green, Refactor

        [TestMethod]
        public void ShouldReturnErrorWhenCNPJIsInvalid()
        {
            var doc = new Documento("123", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
            public void ShouldReturnSuccessWhenCNPJIsValid()
        {
            var doc = new Documento("88777574000111", EDocumentType.CNPJ);
            Assert.IsTrue(doc.Valid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenCPFIsInvalid()
        {
            var doc = new Documento("123", EDocumentType.CPF);
            Assert.IsTrue(doc.Invalid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("17788352870")]
        [DataRow("59771724274")]
        [DataRow("54616347530")]
        public void ShouldReturnSuccessWhenCPFIsValid(string cpf)
        {
            var doc = new Documento(cpf, EDocumentType.CPF);
            Assert.IsTrue(doc.Valid);
        }
    }
}