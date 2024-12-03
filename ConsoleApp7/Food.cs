using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Food : IItem
{
    protected string _name;
    protected int _recoverHP;
    public string Name => _name;
    public int RecoverHP => _recoverHP;
}