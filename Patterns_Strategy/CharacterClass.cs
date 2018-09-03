using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Strategy
{
    /// <summary>
    /// Supertype for the character classes.
    /// 
    /// The Context class in a Stategy Pattern
    /// </summary>
    abstract class ICharacterClass
    {
        public string className { get; protected set; }
        public int level { get; set; }
        public int hitPoints { get; set; }
        public Weapon primaryWeapon { get; protected set; }

        /// <summary>
        /// The Strategy in a Strategy Pattern
        /// </summary>
        protected IAttackBehavior myAtackBehavior;
        protected IDefendBehavior myDefendBehavior;

        /// <summary>
        /// The ContextInterface() in a Strategy Pattern.
        /// </summary>
        public void Attack(ICharacterClass target)
        {
            Console.WriteLine(this.className+ " attacks " + target.className+"!");
            int damage = myAtackBehavior.Attack(this);
            target.Defend(damage);
        }

        /// <summary>
        /// The ContextInterface() in a Strategy Pattern.
        /// </summary>
        /// <param name="damageDealt">Damage to defend against</param>
        public void Defend(int damageDealt)
        {
            myDefendBehavior.Defend(this, damageDealt);

            if (hitPoints<0)
            {
                Console.WriteLine(className + " died.");
            }
            else
            {
                Console.WriteLine(className + " has " + hitPoints + " hit points left.");
            }
        }

    }


    /// <summary>
    /// The Context class in a Stategy Pattern
    /// </summary>
    class Warrior : ICharacterClass
    {
        public Warrior()
        {
            className = "Warrior";
            level = 1;
            hitPoints = 30;
            primaryWeapon = new Broadsword();
            myAtackBehavior = new AttackWithWeapon();
            myDefendBehavior = new DefendWithArmor();
        }
    }

    /// <summary>
    /// The Context class in a Stategy Pattern
    /// </summary>
    class Bandit : ICharacterClass
    {
        public Bandit()
        {
            className = "Bandit";
            level = 1;
            hitPoints = 25;
            primaryWeapon = new Stick();
            myAtackBehavior = new AttackWithWeapon();
            myDefendBehavior = new DefendWithDodge();
        }
    }

    /// <summary>
    /// The Context class in a Stategy Pattern
    /// </summary>
    class Mage : ICharacterClass
    {
        public Mage()
        {
            className = "Mage";
            level = 1;
            hitPoints = 20;
            primaryWeapon = null;
            myAtackBehavior = new CastFireball();
            myDefendBehavior = new DefendWithDodge();
        }
    }
}
