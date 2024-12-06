using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class enemy : ICharacter
{
    public string Name { get; }
    public int _specDamage;
    public IMonsterDrop lout;
    public int count;
    Random random = new Random();
    protected int _baseDamage = 5;
    protected int _hp;
    public Weapon weapon;
    public Armor armor;

    protected enemy(string name, IMonsterDrop lout, int hp, Armor armor, Weapon weapon)
    {
        Name = name;
        this.lout = lout;
        HP = hp;
        this.armor = armor;
        this.weapon = weapon;
    }

    public int HP { get => _hp; private set => _hp = value; }
    public int Damage
    {
        get { if (weapon == null) {  return _baseDamage; }
            else 
            { return weapon.Damage + _baseDamage; } }
    }
    public abstract void SpecAttack();
    public abstract void Attack();
    public abstract void GetDamage(ICharacter character);
    public abstract IMonsterDrop LoutDrop();
}