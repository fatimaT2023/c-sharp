using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasxk6
{
    internal class Warrior : GameCharactercs
    {
          public Warrior(string name, int health) : base(name, health)
             {

             }
             public override void UsespecialAbililty()
             {         
              Console.WriteLine("The Warrior attacks with a sword!");
             }
        public override void TakeDamage(int amount)
        {
            int damage = amount - 2;

            if (damage < 0)
                damage = 0;

            base.TakeDamage(damage);
        }


    }
}


    

    

