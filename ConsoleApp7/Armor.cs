using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Armor : IItem
{
    private string _name;
    private int _defence;
    private int _price;

    public string Name => _name;
    public int Defence => _defence;
    public int Price => _price;

    public Armor(string _name, int _armor, int _price)
    {
        this._name = _name;
        this._defence = _armor;
        this._price = _price;
    }
}