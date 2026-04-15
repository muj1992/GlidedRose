using GildedRoseKata;
using GildedRoseKata.Updaters;
using Xunit;

namespace GildedRose.Tests;

public class ConjuredItemUpdaterTests
{
    private readonly ConjuredUpdater _sut = new();

    [Fact]
    public void Update_DecreasesQualityBy2_BeforeSellDate()
    {
        var item = new Item
        {
            Name = "Conjured Mana Cake",
            SellIn = 3,
            Quality = 10
        };

        _sut.Update(item);

        Assert.Equal(2, item.SellIn);
        Assert.Equal(8, item.Quality);
    }

    [Fact]
    public void Update_DecreasesQualityBy4_AfterSellDate()
    {
        var item = new Item
        {
            Name = "Conjured Mana Cake",
            SellIn = 0,
            Quality = 10
        };

        _sut.Update(item);

        Assert.Equal(-1, item.SellIn);
        Assert.Equal(6, item.Quality);
    }

    [Fact]
    public void Update_NeverAllowsQualityToGoBelowZero_BeforeSellDate()
    {
        var item = new Item
        {
            Name = "Conjured Mana Cake",
            SellIn = 5,
            Quality = 1
        };

        _sut.Update(item);

        Assert.Equal(0, item.Quality);
    }

    [Fact]
    public void Update_NeverAllowsQualityToGoBelowZero_AfterSellDate()
    {
        var item = new Item
        {
            Name = "Conjured Mana Cake",
            SellIn = 0,
            Quality = 3
        };

        _sut.Update(item);

        Assert.Equal(0, item.Quality);
    }
}