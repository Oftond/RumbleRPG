using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

