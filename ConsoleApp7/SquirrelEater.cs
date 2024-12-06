using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SquirrelEater : ABoss
{
    public SquirrelEater(string name, IMonsterDrop lout, int hp, Armor armor, Weapon weapon) : base(name, lout, hp, armor, weapon) { }

    public override void Attack(Player character)
    {
        Console.WriteLine($"{Name} атакует {character.Name}!");
        character.takedamage(Damage);
    }

    public override void Block(ICharacter character)
    {
        Console.WriteLine($"{Name} ставит блок против {character.Name}!");
    }

    public override void GetDamage(ICharacter character)
    {
        _hp -= character.Damage - armor.Defence <= 0 ? 1 : character.Damage - armor.Defence;
    }

    public override void Heal()
    {
        _hp += 40;
        Console.WriteLine($"{Name} восстановил 40 здоровья");
    }

    public override IMonsterDrop LoutDrop()
    {
        Console.WriteLine($"{Name} Погиб!\n Из него выпало {lout}");
        return lout;
    }

    public override void SpecAttack()
    {
        Console.WriteLine($"{Name} готовит специальную атаку!");
    }

    public override void SuperCharge(ICharacter character)
    {
        Console.WriteLine($"{Name} совершает супер удар по {character.Name}!");
    }
}