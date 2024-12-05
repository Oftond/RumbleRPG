using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class geroi : dayn
    {
        public geroi(string name, int hp, int Damage, int maxitems)
        {
            this.maxitems = maxitems;
            this.name = name;
            this.hp = hp;
            damage = Damage;
            typeWeapon = null;
            typearmor = null;
            inv = new Inventory(maxitems);
        }
        public string name;
        public int hp;
        public int damage;
        public int coins;
        public int maxitems;
        public int Damage => damage + typeWeapon.damage;
        public Iweapon typeWeapon;
        public Iarmor typearmor;
        Inventory inv;
        public void pickup(Iitem item)
        {
            inv.addItem(item);
        }
        public void buyitem(Iitem item)
        {
            coins -= item.cost;
            pickup(item);
        }
        public void getcoin(int coin)
        {
            coins += coin;
        }
        public void solditem(Iitem item)
        {
            coins += item.cost / 1.5;
            inv.removeItem(item);
        }
        public void rest()
        {
            hp += 1000;
        }
        public void healitem(Iitem item)
        {
            if(inv.searchItem(ref item))
            {
                hp += item.recoverhp;
            }
            else
                Console.WriteLine("тебе нечем лечиться");
        }
        public void attack(enemy enemy)
        {
            enemy.hp -= Damage;
        }
        public void takedamage(int damage)
        {
            
            hp -= damage;
        }
        public void block(int damage)
        {
            hp -= damage / 2;

        }

    }
}
