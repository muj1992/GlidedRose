using GildedRoseKata.Factories;
using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> _items;

    public GildedRose(IList<Item> Items)
    {
        _items = Items ?? throw new ArgumentNullException();
    }

    public void UpdateQuality()
    {
        foreach (var item in _items) {
            
            ItemUpdaterFactory.Create(item).Update(item);
        }
    }
        
}