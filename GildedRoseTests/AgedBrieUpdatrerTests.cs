using GildedRoseKata;
using GildedRoseKata.Updaters;
using Xunit;

namespace GildedRoseTests;

public class AgedBrieUpdatrerTests
{
    private readonly AgedBrieUpdater _sut = new();

    [Fact]
    public void Update_IncreasesQualityBy1_Before_Sell_Date()
    {
        var item = new Item
        {
            Name = "Aged Brie",
            SellIn = 5,
            Quality = 10
        };

        _sut.Update(item);

        Assert.Equal(4, item.SellIn);
        Assert.Equal(11, item.Quality);
    }

    [Fact]
    public void Update_IncreasesQualityBy2_After_Sell_Date()
    {
        var item = new Item
        {
            Name = "Aged Brie",
            SellIn = 0,
            Quality = 10
        };

        _sut.Update(item);

        Assert.Equal(-1, item.SellIn);
        Assert.Equal(12, item.Quality);
    }
}
