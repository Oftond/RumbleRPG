using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class RottenFlesh : IMonsterDrop
{
    public string Name => "Гнилая плоть";

    public int Price => 5;
}