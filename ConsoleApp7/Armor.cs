using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD

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
=======
class Armor
{
    public class Helmet
    {
        public string Name { get; }
        private int _armor;
        public int Armor
        {
        get 
            { return _armor; }
                set
            {
                _armor = value;
                    if (value >1)
                {
                    _armor = 1;

                }
                    if (value < 0)
                {
                    _armor = 0;
                }
            }
        }
        public Helmet(string name, int value)
        {
            Name = name;
            Armor = value;
        }
    }
    public class Boots
    {
        public string Name { get; }
        private int _armor;
        public int Armor
        {
            get
            { return _armor; }
            set
            {
                _armor = value;
                if (value > 1)
                {
                    _armor = 1;

                }
                if (value < 0)
                {
                    _armor = 0;
                }
            }
        }
        public Boots(string name, int value)
        {
            Name = name;
            Armor = value;
        }
    }
}

>>>>>>> 4edfdf1bd9ad03c575a5d175bfd00066fa5fdbc4
