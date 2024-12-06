using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Weapon : IItem
{
    private string _name;
    private int _damage;
    private int _price;
    private int minDamage { get; }
    private int maxDamage { get; }

    public string Name => _name;
    public int Damage => (minDamage + maxDamage) / 2;
    public int Price => _price;

    public Weapon(string _name, int _damage, int _price)
    {
        this._name = _name;
        this._damage = _damage;
        this._price = _price;
    }
}