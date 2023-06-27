using lanchonete_55.Domain.Entities;
using lanchonete_55.Domain.UseCases.CreateCustomer;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace lanchonete_55.Infra.Database.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly Context _context;

        public CustomerRepository()
        {
            _context = new Context();
        }

        public void Create(CreateCustomerSignature entity)
        {
            MySqlCommand cmd = new MySqlCommand("SELECT 1", _context._connection);
            cmd.ExecuteNonQuery();
        }

        public Customer Update(CreateCustomerSignature entity)
        {
            throw new NotImplementedException();
        }
    }
}
