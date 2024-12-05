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

    public bool searchItem<T> (ref T search)
    {
        foreach (var item in items)
        {
            if (item is T alo)
            {
                search = alo;
                return true;
            }
        }
        return false;
    }

    public bool addItem(Iitem item)
    {
        if (items.Count < MaxItems)
        {
            items.Add(item);
            return true;
        }
        else
            return false;
    }

    public void removeItem(Iitem item)
    {
        items.Remove(item);
    }
}