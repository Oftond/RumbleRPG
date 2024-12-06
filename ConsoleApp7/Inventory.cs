using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Inventory
{
    private List<IItem> items;
    public int MaxItems;

    public Inventory(int maxitems)
    {
        MaxItems = maxitems;
    }

    public bool searchItem<T>(T search)
    {
        foreach (var item in items)
        {
            if (item is T food)
            {
                return true;
            }
        }
        return false;
    }

    public bool addItem(IItem item)
    {
        if (items.Count < MaxItems)
        {
            items.Add(item);
            return true;
        }
        else
            return false;
    }

    public void removeItem(IItem item)
    {
        items.Remove(item);
    }

    public void ShowInv()
    {
        foreach (var item in items)
        {
            Console.WriteLine(item.Name);
        }
    }

    public void ShowFood()
    {
        foreach(var item in items.Where(x => x is Food))
        {
            Console.WriteLine(item);
        }
    }
}