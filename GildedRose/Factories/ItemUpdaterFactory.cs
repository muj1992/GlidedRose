using GildedRoseKata.Updaters;

namespace GildedRoseKata.Factories;

public static class ItemUpdaterFactory
{
    private static readonly ItemUpdater NormalItemUpdater = new NormalItemUpdater();
    private static readonly ItemUpdater AgedBrieUpdater = new AgedBrieUpdater();
    private static readonly ItemUpdater BackstagePassUpdater = new BackStageUpdater();
    private static readonly ItemUpdater SulfurasUpdater = new SulfurasUpdater();
    private static readonly ItemUpdater ConjuredUpdater = new ConjuredUpdater();

    public static ItemUpdater Create(Item item) => 
        item.Name switch
        {
            ItemNames.AgedBrie => AgedBrieUpdater,
            ItemNames.BackstagePass => BackstagePassUpdater,
            ItemNames.Sulfuras => SulfurasUpdater,
            ItemNames.Conjured => ConjuredUpdater,
            _ => NormalItemUpdater
        };
}
