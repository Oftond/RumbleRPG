using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ICharacter
{
    string Name { get; }
    int HP { get; }
    int Damage { get; }
}