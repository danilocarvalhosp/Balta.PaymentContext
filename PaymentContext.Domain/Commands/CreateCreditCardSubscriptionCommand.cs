using PaymentContext.Domain.Enums;

namespace PaymentContext.Domain.Commands{
    public class CreateCreditCardSubscriptionCommand{
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Document { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string CardHolderName { get; set; } = string.Empty;
        public string CardNumber { get; set; } = string.Empty;
        public string LastTransactionNumber { get; set; } = string.Empty;
        public string PaymentNumber { get; set; } = string.Empty;
        public DateTime PaidDate { get; set; }
        public DateTime? ExpireDate { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPaid { get; set; }
        public string Payer { get; set; } = string.Empty;
        public string PayerDocument { get; set; } = string.Empty;
        public EDocumentType PayerDocumentType { get; set; }
        public string? Street { get; set; }
        public string? Number { get; set; }
        public string? Neighborhood { get;  set; }
        public string? City { get;  set; }
        public string? State { get;  set; }
        public string? Country { get;  set; }
        public string? ZipCode { get;  set; }
        public string PayerEmail { get; set; } = string.Empty;
    }
}