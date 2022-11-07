using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapitalPlatforms.Application.DiscretionaryRules.Queries.GetDiscretionaryRule
{
    public interface IGetDiscretionaryRuleQuery
    {
        DiscretionaryRuleModel Execute(int Id);
    }
}
