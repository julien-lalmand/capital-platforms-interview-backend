using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlatforms.Application.Consultants.Queries.GetConsultant
{
    public interface IGetConsultantQuery
    {
        ConsultantModel Execute(int Id);
    }
}
