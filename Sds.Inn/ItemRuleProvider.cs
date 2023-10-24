using Sds.Inn.DoNotChange;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sds.Inn
{
    public class ItemRuleProvider : IItemRuleProvider
    {
        private IList<ItemRule> _items = new List<ItemRule>
        {
            new("+5 Dexterity Vest", -1, -2),
            new("Aged Brie", 1, 1),
            new("Elixir of the Mongoose", -1, -2),
            new("Sulfuras", 0, 0),
            new("Backstage passes", 1, -50),
            new("Conjured", -2, -4)
        };

        public IEnumerable<ItemRule> GetItemRules()
        {
            return _items;
        }
    }
}
