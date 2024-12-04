using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Food : IItem
{
    private string _name;
    private int _recoverHP;
    private int _price;

    public string Name => _name;
    public int RecoverHP => _recoverHP;
    public int Price => _price;

    public Food(string _name, int _recoverHp, int _price)
    {
        this._name = _name;
        this._recoverHP = _recoverHp;
        this._price = _price;
    }
}