using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class enemy : ICharacter
{
    public int _specDamage;
    public IMonsterDrop lout;
    public int count;
    public event Action<enemy> onDath;
    public event Action<enemy> damage;
    Random random = new Random();
    private int _baseDamage = 5;
    private int _hp;
    public Weapon weapon;
    public int HP { get => _hp; private set => _hp = value; }
    public int Damage {
        get
        {
            if (weapon == null)
            {
                return _baseDamage;
            }
            else
            {
                return weapon.GetDamage() + _baseDamage;
            }
        }
        set => _baseDamage = value;
    }
    public void SpecAttack()
    {
        _specDamage += Hero.MaxHP;
    }
    public void LoutDrop()
    {
        Console.WriteLine($"Из {Name} выпало {lout}");
        return lout;
    }
    public int Armores { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string Name { get; }
}

