using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

