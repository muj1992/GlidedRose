namespace GildedRoseKata.Updaters;

public class ConjuredUpdater :ItemUpdater
{
    protected override void UpdateBeforeSellDate(Item item)
    {
        DecreaseQuality(item, 2);
    }

    protected override void UpdateAfterSellDate(Item item)
    {
        if (item.SellIn < 0)
        {
            DecreaseQuality(item, 2);
        }
    }
}
