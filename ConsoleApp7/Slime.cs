using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Slime : enemy
{

    public Slime(string name, IMonsterDrop lout, int hp) : base(name, lout, hp)
    {

    }
    public override void Attack()
    {
        Console.WriteLine($"{Name} атакует {weapon.Name}!");
    }
    public override void SpecAttack()
    {
        Console.WriteLine($"{Name} готовит специальную атаку!");
    }
    public override IMonsterDrop LoutDrop()
    {
        Console.WriteLine($"{Name} Погиб!\t Из него выпало {lout}");
        return lout;
    }
}
