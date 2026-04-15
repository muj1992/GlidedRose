using GildedRoseKata;
using GildedRoseKata.Updaters;
using Xunit;

namespace GildedRoseTests;

public class NormalItemUpdaterTests
{
    private readonly NormalItemUpdater _sut = new();

    [Fact]
    public void Update_DecreasesQualityBy1_Before_SellDate()
    {
        var item = new Item
        {
            Name = "Elixir of the Mongoose",
            SellIn = 5,
            Quality = 10
        };

        _sut.Update(item);

        Assert.Equal(4, item.SellIn);
        Assert.Equal(9, item.Quality);
    }

    [Fact]
    public void Update_DecreasesQualityBy2After_SellDate()
    {
        var item = new Item
        {
            Name = "Elixir of the Mongoose",
            SellIn = 0,
            Quality = 10
        };

        _sut.Update(item);

        Assert.Equal(-1, item.SellIn);
        Assert.Equal(8, item.Quality);
    }

    [Fact]
    public void Update_DoesNotAllowQuality_To_GoBelow_Zero()
    {
        var item = new Item
        {
            Name = "Elixir of the Mongoose",
            SellIn = 0,
            Quality = 1
        };

        _sut.Update(item);

        Assert.Equal(0, item.Quality);
    }
}
