using Sds.Inn.DoNotChange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sds.Inn
{
    public interface IItemRuleProvider
    {
        IEnumerable<ItemRule> GetItemRules();
    }
}
