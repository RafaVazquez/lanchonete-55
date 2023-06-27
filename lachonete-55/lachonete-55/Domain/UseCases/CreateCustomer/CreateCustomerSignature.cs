using lanchonete_55.Domain.Entities;

namespace lanchonete_55.Domain.UseCases.CreateCustomer
{
    public class CreateCustomerSignature
    {
        public string? Name { get; set; }
        public string? Email { get; set; }
        public string? CPF { get; set; }
    }
}
