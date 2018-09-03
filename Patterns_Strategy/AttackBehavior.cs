using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Strategy
{
    /// <summary>
    /// The Strategy interface in a Stategy Pattern
    /// </summary>
    interface IAttackBehavior
    {
        /// <summary>
        /// The AlgorithmInterface() in a Strategy Pattern
        /// </summary>
        /// <returns>Damage dealt</returns>
        int Attack(ICharacterClass attacker);
    }

    class AttackWithWeapon : IAttackBehavior
    {
        public int Attack(ICharacterClass attacker)
        {
            //base damage for weapon attack

            int damage = 3;

            if (attacker.primaryWeapon !=null)
            {
                damage += attacker.primaryWeapon.damage;
            Console.WriteLine("The "+attacker.className+" attacks with their "+attacker.primaryWeapon.weaponName+", dealing "+damage+" damage");
            }
            else
            {
                Console.WriteLine("The " + attacker.className + " makes an unarmed attack, dealing " + damage + " damage");
            }

            return damage;
        }
    }

    class CastFireball : IAttackBehavior
    {
        public int Attack(ICharacterClass attacker)
        {
            int damage = 15;
            Console.WriteLine("The " + attacker.className + " casts a mighty Fireball, dealing " + damage + " damage");

            return damage;
        }
    }
}
