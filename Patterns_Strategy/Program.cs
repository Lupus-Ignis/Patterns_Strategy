/*----------------------
 * 
 * Design Patterns
 * 
 * Implementation 2018 by Tore Sæderup
 * 
 * Use however you want
 * 
 * --------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// "The Stategy pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable.
/// Strategy lets the algorithm vary independently from clients that use it"
///  - Head First Design Patterns by Freeman and Freeman
/// </summary>
namespace Patterns_Strategy
{
    /// <summary>
    /// An example of Strategy Pattern usage. A character in a Role Playing Game can have different types of attack or defense based on their character class.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Warrior myWarrior = new Warrior();
            Bandit myBandit = new Bandit();
            Mage myMage = new Mage();

            myWarrior.Attack(myBandit);

            Console.WriteLine();

            myBandit.Attack(myMage);

            Console.WriteLine();

            myMage.Attack(myWarrior);

            Console.ReadKey();
        }
    }
}
