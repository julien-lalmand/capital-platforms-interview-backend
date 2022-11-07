namespace CapitalPlatforms.Application.Customers.Commands.DeleteCustomer
{
    public interface IDeleteCustomerCommand
    {
        void Execute(DeleteCustomerModel model);
    }
}
