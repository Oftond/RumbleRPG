using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class AArmor : IItem
{
    private string _name;
    private int _armor;
    private int _price;

    public string Name => _name;
    public int Armor => _armor;
    public int Price => _price;

    public AArmor(string _name, int _armor, int _price)
    {
        this._name = _name;
        this._armor = _armor;
        this._price = _price;
    }
}