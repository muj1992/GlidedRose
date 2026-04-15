using GildedRoseKata;
using GildedRoseKata.Updaters;
using Xunit;

namespace GildedRoseTests;

public class BackstageUpdaterTests
{
    private readonly BackStageUpdater _sut = new();

    [Fact]
    public void Update_IncreasesQualityBy3When_MoreThan7DaysRemain()
    {
        var item = new Item
        {
            Name = "Backstage passes to a TAFKAL80ETC concert",
            SellIn = 8,
            Quality = 10
        };

        _sut.Update(item);

        Assert.Equal(7, item.SellIn);
        Assert.Equal(13, item.Quality);
    }

    [Fact]
    public void Update_IncreasesQualityBy3_When_ThereAre7DaysOrLess()
    {
        var item = new Item
        {
            Name = "Backstage passes to a TAFKAL80ETC concert",
            SellIn = 7,
            Quality = 10
        };

        _sut.Update(item);

        Assert.Equal(6, item.SellIn);
        Assert.Equal(13, item.Quality);
    }

    [Fact]
    public void Update_IncreasesQualityBy4When_ThereAre2DaysOrLess()
    {
        var item = new Item
        {
            Name = "Backstage passes to a TAFKAL80ETC concert",
            SellIn = 2,
            Quality = 10
        };

        _sut.Update(item);

        Assert.Equal(1, item.SellIn);
        Assert.Equal(14, item.Quality);
    }

    [Fact]
    public void Update_DropsQualityToZero_After_Concert()
    {
        var item = new Item
        {
            Name = "Backstage passes to a TAFKAL80ETC concert",
            SellIn = 0,
            Quality = 10
        };

        _sut.Update(item);

        Assert.Equal(-1, item.SellIn);
        Assert.Equal(0, item.Quality);
    }
}
