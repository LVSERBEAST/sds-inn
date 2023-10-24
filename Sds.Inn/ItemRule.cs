using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sds.Inn
{
    public class ItemRule
    {
        public ItemRule(string name, int quality, int qualityExpiredRule)
        {
            Name = name;
            QualityRule = quality;
            QualityExpiredRule = qualityExpiredRule;
        }

        public string Name { get; init; }
        public int QualityRule { get; set; }
        public int QualityExpiredRule { get; set; }
    }
}
