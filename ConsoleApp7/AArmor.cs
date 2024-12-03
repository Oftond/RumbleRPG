using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class AArmor : IItem
{
    protected string _name;
    public string Name => _name;
    protected int _armor;
    public int Armor => _armor;
}