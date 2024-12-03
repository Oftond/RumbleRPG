using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class AWeapon : IItem
{
    protected string _name;
    protected int _damage;
    public string Name => _name;
    public int Damage => _damage;
}