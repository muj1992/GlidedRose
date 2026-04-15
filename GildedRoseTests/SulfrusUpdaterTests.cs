using GildedRoseKata;
using GildedRoseKata.Updaters;
using Xunit;

namespace GildedRoseTests;

public class SulfurasUpdaterTests
{
    private readonly SulfurasUpdater _sut = new();

    [Fact]
    public void Update_DoesNotChange_SellInOrQuality()
    {
        var item = new Item
        {
            Name = "Sulfuras, Hand of Ragnaros",
            SellIn = 0,
            Quality = 80
        };

        _sut.Update(item);

        Assert.Equal(0, item.SellIn);
        Assert.Equal(80, item.Quality);
    }
}
