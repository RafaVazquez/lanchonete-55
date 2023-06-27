using lanchonete_55.Infra.Database;
using lanchonete_55.Infra.Database.Repository;
using MySql.Data.MySqlClient;
using System.Data;

namespace lanchonete_55.Domain.UseCases.CreateCustomer
{
    public class CreateCustomer : ICreateCustomer 
    {
        private readonly ICustomerRepository iCustomerRepository;

        public Task InsertAsync(CreateCustomerSignature signature)
        {
            iCustomerRepository.Create(signature);
            return Task.CompletedTask;
        }
    }
}
