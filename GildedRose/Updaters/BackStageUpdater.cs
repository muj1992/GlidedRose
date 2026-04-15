namespace GildedRoseKata.Updaters;

public class BackStageUpdater : ItemUpdater
{
    protected override void UpdateBeforeSellDate(Item item)
    {
        IncreaseQuality(item);

        if (item.SellIn <= 10)
        {
            IncreaseQuality(item);
        }

        if (item.SellIn <= 8)
        {
            IncreaseQuality(item);
        }

        if (item.SellIn <= 3)
        {
            IncreaseQuality(item);
        }
    }

    protected override void UpdateAfterSellDate(Item item)
    {
        if (item.SellIn < 0)
        {
            item.Quality = 0;
        }
    }
}
