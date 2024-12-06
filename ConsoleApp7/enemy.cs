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
    public event Action<enemy> onDath;
    public event Action<enemy> damage;
    Random random = new Random();
    private int _baseDamage = 5;
    private int _hp;
    public Weapon weapon;

    protected enemy(string name, IMonsterDrop lout, int hp)
    {
        Name = name;
        this.lout = lout;
        HP = hp;
    }

    public int HP { get => _hp; private set => _hp = value; }
    public int Damage {
        get { if (weapon == null) {  return _baseDamage; }
            else 
            { return weapon.GetDamage() + _baseDamage; } }
        set => _baseDamage = value;
    }
    public abstract void SpecAttack();
    public abstract void Attack();
    public abstract void LoutDrop();
    public int Armores { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    
}

