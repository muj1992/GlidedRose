namespace GildedRoseKata.Updaters;

public class NormalItemUpdater : ItemUpdater
{
    protected override void UpdateBeforeSellDate(Item item)
    {
        DecreaseQuality(item);
    }

    protected override void UpdateAfterSellDate(Item item)
    {
        if (item.SellIn < 0)
        {
            DecreaseQuality(item);
        }
    }
}
