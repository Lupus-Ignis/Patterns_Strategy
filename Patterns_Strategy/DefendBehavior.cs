using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_Strategy
{
    /// <summary>
    /// The Strategy Interface in a Strategy Pattern.
    /// </summary>
    interface IDefendBehavior
    {
        /// <summary>
        /// The AlgorithmInterface() in a Strategy Pattern.
        /// </summary>
        /// <param name="damageTaken">The incoming damage.</param>
        void Defend(ICharacterClass defender, int damageTaken);
    }


    /// <summary>
    /// The ConcreteStrategy in a Strategy Pattern.
    /// </summary>
    class DefendWithDodge : IDefendBehavior
    {

        /// <summary>
        /// Has a flat 30% chance of dodging the attack.
        /// 
        /// The AlgorithmInterface() in a Strategy Pattern.
        /// </summary>
        /// <param name="defender">The defending character</param>
        /// <param name="damageTaken">The incoming damage.</param>
        public void Defend(ICharacterClass defender, int damageTaken)
        {
            Random rand = new Random(DateTime.Now.Millisecond);
            if (rand.Next(1, 11) <= 3)
            {
                Console.WriteLine("The " + defender.className + " dodges deftly, taking no damage.");
            }
            else
            {
                Console.WriteLine("The " + defender.className + " tries to dodge, but fails, taking the full " + damageTaken + " damage.");
                defender.hitPoints -= damageTaken;
            }
        }
    }

    /// <summary>
    /// The ConcreteStrategy in a Strategy Pattern.
    /// </summary>
    class DefendWithArmor : IDefendBehavior
    {
        /// <summary>
        /// Subtracts a flat 5 points from damage.
        /// 
        /// The AlgorithmInterface() in a Strategy Pattern.
        /// </summary>
        /// <param name="defender">The defending character</param>
        /// <param name="damageTaken">The incoming damage.</param>
        void IDefendBehavior.Defend(ICharacterClass defender, int damageTaken)
        {
            damageTaken = damageTaken - 5;
            if (damageTaken < 0)
            {
                damageTaken = 0;
            }
            Console.WriteLine("The "+defender.className+"'s armor absorbs 5 damage, letting "+damageTaken+" through.");
            defender.hitPoints -= damageTaken;
        }
    }
}
