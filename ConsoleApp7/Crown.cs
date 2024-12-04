using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Crown : IItem
{
    private int _price;

    public string Name => "Корона";
    public int Price => _price;

    public Crown(int _price)
    {
        this._price = _price;
    }
}