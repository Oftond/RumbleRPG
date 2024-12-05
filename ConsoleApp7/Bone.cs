using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class Bone : IMonsterDrop
{
    public string Name => "Кость";

    public int Price => 15;
}