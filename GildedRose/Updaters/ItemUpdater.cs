namespace GildedRoseKata.Updaters;

public abstract class ItemUpdater
{
    private const int MaxQuality = 50;
    private const int MinQuality = 0;

    public void Update(Item item)
    {
        UpdateBeforeSellDate(item);
        UpdateSellIn(item);
        UpdateAfterSellDate(item);
    }

    protected virtual void UpdateBeforeSellDate(Item item) { }
    
    protected virtual void UpdateSellIn(Item item) => item.SellIn--;
    
    protected virtual void UpdateAfterSellDate(Item item) { }
    
    protected static void IncreaseQuality(Item item, int amount = 1) 
        => item.Quality = (item.Quality + amount) > MaxQuality 
               ? MaxQuality 
               : item.Quality + amount;
    protected static void DecreaseQuality(Item item, int amount = 1)
        => item.Quality = (item.Quality - amount) < MinQuality 
               ? MinQuality 
               : item.Quality - amount;
}
