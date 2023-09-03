using PaymentContext.Domain.Enums;
using PaymentContext.Shared.ValueObjects;
using Flunt.Validations;


namespace PaymentContext.Domain.ValueObjects
{
    public class Documento : ValueObject

    {
        public Documento(string number, EDocumentType type)
        {
            Number = number;
            Type = type;

            AddNotifications(new Contract()
                .Requires()
                .IsTrue(Validate(), "Document.Number", "Documento Inválido")
            );
        }

        public string Number { get; private set; } = string.Empty;
        public EDocumentType Type { get; private set; }

        private bool Validate(){
            if(Type == EDocumentType.CNPJ && Number.Length == 14)
            return true;

            if(Type == EDocumentType.CPF && Number.Length == 11)
            return true;

            return false;
        }
    }
}