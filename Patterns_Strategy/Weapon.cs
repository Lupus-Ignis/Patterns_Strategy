using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Strategy
{
    abstract class Weapon
    {
        public string weaponName { get; protected set; }
        public int damage { get; protected set; }
    }

    class Broadsword : Weapon
    {
        public Broadsword()
        {
            weaponName = "broadsword";
            damage = 5;
        }
    }

    class Stick : Weapon
    {
        public Stick()
        {
            weaponName = "stick";
            damage = 1;
        }
    }
}
