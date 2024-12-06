using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
public class Weapon : IItem
{
    private string _name;
    private int _damage;
    private int _price;

    public string Name => _name;
    public int Damage => _damage;
    public int Price => _price;

    public Weapon(string _name, int _damage, int _price)
    {
        this._name = _name;
        this._damage = _damage;
        this._price = _price;
    }
}
=======
public abstract class Weapon
{
    public string Name { get; }
    public int minDamage { get; private set; }
    public int maxDamage { get; private set; }

    public Weapon(string name)
    {
        Name = name;
    }

    public Weapon(string name, int n1, int n2) : this(name)
    {
        SetDamageParams(n1, n2);
    }

    public void SetDamageParams(int number1, int number2)
    {
        if (number1 > number2)
        {
            (minDamage, maxDamage) = (number2, number1);
            Console.WriteLine("Неправельный ввод " + Name);
        }
        else
        {
            (minDamage, maxDamage) = (number1, number2);
        }

        if (minDamage < 1)
        {
            minDamage = 1;
        }

        if (maxDamage <= 1)
        {
            maxDamage = 10;
        }
    }
    public int GetDamage() => (minDamage + maxDamage) / 2;
}

>>>>>>> 4edfdf1bd9ad03c575a5d175bfd00066fa5fdbc4
