using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class ABoss : enemy
{
    protected ABoss(string name, IMonsterDrop lout, int hp, Armor armor, Weapon weapon) : base(name, lout, hp, armor, weapon)
    {
    }

    public abstract void SuperCharge(ICharacter character);

    public abstract void Heal();

    public abstract void Block(ICharacter character);
}