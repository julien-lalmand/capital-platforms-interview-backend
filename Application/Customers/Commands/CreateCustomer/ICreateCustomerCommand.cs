namespace CapitalPlatforms.Application.Customers.Commands.CreateCustomer
{
    public interface ICreateCustomerCommand
    {
        int Execute(CreateCustomerModel model);
    }
}
