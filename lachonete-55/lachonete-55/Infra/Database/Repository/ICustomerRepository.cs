using lanchonete_55.Domain.Entities;
using lanchonete_55.Domain.UseCases.CreateCustomer;

namespace lanchonete_55.Infra.Database.Repository
{
    public interface ICustomerRepository
    {
        void Create(CreateCustomerSignature signature);
        Customer Update(CreateCustomerSignature signature);
    }
}
