using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasxk6
{
    internal class Wizard:GameCharactercs
    {
        public Wizard(string name ,int health ):base(name ,health)
        {

        }
        public override void UsespecialAbililty()
        {
            Console.WriteLine("The wizerd uses magic");
        }
        public override void TakeDamage(int amount)
        {
            base.TakeDamage(amount);
        }
    }
}
