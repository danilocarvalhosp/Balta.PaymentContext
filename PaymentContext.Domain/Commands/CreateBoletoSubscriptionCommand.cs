using Flunt.Notifications;
using Flunt.Validations;
using PaymentContext.Domain.Enums;
using PaymentContext.Shared.Commands;

namespace PaymentContext.Domain.Commands{
    public class CreateBoletoSubscriptionCommand : Notifiable, ICommand
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Document { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        public string BarCode { get; set; } = string.Empty;
        public string BoletoNumber { get; set; } = string.Empty;
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

        public event EventHandler? CanExecuteChanged;

        public void Validate()
        {
            AddNotifications(new Contract()
                .Requires()
                .HasMinLen(FirstName, 3, "Name.FirstName", "O nome deve conter pelo menos 3 caracteres")
                .HasMaxLen(FirstName, 40, "Name.FirstName", "O nome deve conter até 40 caracteres")
                .HasMinLen(LastName, 3, "Name.LastName", "O sobrenome deve conter pelo menos 3 caracteres")
            );
        }
    }
}