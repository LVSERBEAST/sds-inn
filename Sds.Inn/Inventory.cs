using Sds.Inn.DoNotChange;

namespace Sds.Inn;

public class Inventory
{
    private readonly IItemProvider _itemProvider;

    public Inventory(IItemProvider itemProvider)
    {
        _itemProvider = itemProvider;
    }

    public void UpdateQuality()
    {
        var items = _itemProvider.GetItems();

        foreach (var item in items)
        {
            switch(item.Name)
            {
                case "Aged Brie":
                    UpdateQualityAgedBrie(item);
                    break;
                case "Backstage passes":
                    UpdateQualityBackstagePasses(item);
                    break;
                case "Conjured":
                    UpdateQualityConjured(item);
                    break;
                case "Sulfuras":
                    break;
                default:
                    UpdateQualityDefault(item);
                    break;
            }

            if (item.Quality < 1)
                item.Quality = 0;

            item.SellIn = --item.SellIn;

            if (item.SellIn < 1)
                item.SellIn = 0;
        }
    }

    public void UpdateQualityDefault(Item item)
    {
        if (item.SellIn > 0)
            --item.Quality;
        else
            item.Quality = item.Quality - 2;

        if (item.Quality < 1)
            item.Quality = 0;
    }

    public void UpdateQualityAgedBrie(Item item)
    {
        if (item.SellIn > 0)
            ++item.Quality;
        else
            item.Quality = item.Quality - 2;
    }

    public void UpdateQualityBackstagePasses(Item item)
    {
        if (item.SellIn > 0)
            ++item.Quality;
        else
            item.Quality = 0;
    }

    public void UpdateQualityConjured(Item item)
    {
        if (item.SellIn > 0)
            item.Quality = item.Quality - 2;
        else
            item.Quality = item.Quality - 4;
    }
}
