using Sds.Inn.DoNotChange;

namespace Sds.Inn;

public class Inventory
{
    private readonly IItemProvider _itemProvider;
    private readonly IItemRuleProvider _itemRuleProvider;

    public Inventory(IItemProvider itemProvider, IItemRuleProvider itemRuleProvider)
    {
        _itemProvider = itemProvider;
        _itemRuleProvider = itemRuleProvider;
    }

    public void UpdateQuality()
    {
        var items = _itemProvider.GetItems();
        var itemRules = _itemRuleProvider.GetItemRules();

        foreach (var item in items)
        {
            ItemRule itemRule = itemRules.Single(x => x.Name == item.Name);

            if (item.SellIn == 0)
            {
                item.Quality = item.Quality + itemRule.QualityExpiredRule;
            }
            else
            {
                item.Quality = item.Quality + itemRule.QualityRule;
            }

            item.SellIn = --item.SellIn;

            if (item.SellIn < 1)
            {
                item.SellIn = 0;
            }

            if (item.Quality < 1)
            {
                item.Quality = 0;
            }
            else if (item.Quality > 50 && item.Name.ToLower() != "sulfuras")
            {
                item.Quality = 50;
            }
        }
    }
}
