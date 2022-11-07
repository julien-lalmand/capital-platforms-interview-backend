namespace CapitalPlatforms.Application.Customers.Commands.UpdateCustomer
{
    public interface IUpdateCustomerCommand
    {
        void Execute(UpdateCustomerModel model);
    }
}
