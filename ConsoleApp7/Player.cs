using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Player : ICharacter
    {
        public string name;
        private int hp;
        private int _maxHp;
        private int damage;
        private int coins;
        private int maxitems;

        public int HP => hp;

        public Player(string name, int hp, int Damage, int maxitems)
        {
            _maxHp = hp;
            this.maxitems = maxitems;
            this.name = name;
            this.hp = hp;
            damage = Damage;
            typeWeapon = null;
            typearmor = null;
            inv = new Inventory(maxitems);
        }

        public int Damage => damage + typeWeapon.Damage;
        public Weapon typeWeapon;
        public Armor typearmor;
        Inventory inv;

        public void pickup(IItem item)
        {
            inv.addItem(item);
        }

        public void buyitem(IItem item)
        {
            coins -= item.Price;
            pickup(item);
        }

        public void getcoin(int coin)
        {
            coins += coin;
        }

        public void solditem(IItem item)
        {
            coins += (int)(item.Price / 1.5);
            inv.removeItem(item);
        }

        public void rest()
        {
            hp = _maxHp;
        }

        public void healitem(IItem item)
        {
            if (item is Food food)
            {
                hp += food.RecoverHP;
            }
        }

        public void attack(enemy enemy)
        {
            enemy.GetDamage(this);
            Console.WriteLine($"{name} ударил {enemy.Name}");
            Console.WriteLine($"{enemy.Name} получил {Damage} урона");
        }

        public void takedamage(int damage)
        {
            hp -= damage;
            Console.WriteLine($"{name} получил {damage} урона.");
        }

        public void block(int damage)
        {
            hp -= damage / 2;
            Console.WriteLine($"{name} ставит блок против {damage} урона.");
            Console.WriteLine($"{name} получил {damage / 2} урона.");
        }
    }
}