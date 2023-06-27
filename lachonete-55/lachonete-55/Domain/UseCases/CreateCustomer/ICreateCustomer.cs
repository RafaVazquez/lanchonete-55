namespace lanchonete_55.Domain.UseCases.CreateCustomer
{
    public interface ICreateCustomer
    {
        Task InsertAsync(CreateCustomerSignature signature);
    }
}
