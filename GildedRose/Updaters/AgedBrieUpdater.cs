namespace GildedRoseKata.Updaters;

public class AgedBrieUpdater : ItemUpdater
{
    protected override void UpdateBeforeSellDate(Item item)
    {
        IncreaseQuality(item);
    }
    
    protected override void UpdateAfterSellDate(Item item)
    {
        if (item.SellIn < 0)
        {
            IncreaseQuality(item);
        }
    }
}