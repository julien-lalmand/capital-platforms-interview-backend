namespace CapitalPlatforms.Application.Consultants.Commands.CreateConsultant
{
    public interface ICreateConsultantCommand
    {
        int Execute(CreateConsultantModel model);
    }
}
