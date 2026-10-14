using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasxk6
{
    abstract class GameCharactercs
    {
        private string _name;
        private int _health;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        protected int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                    _health = 0;
                else if (value > 100)
                    _health = 100;
                else
                    _health = value;
            }
        }

        public GameCharactercs(string name, int health)
        {
            Name = name;
            Health = health;
        }
        public abstract void UsespecialAbililty();

        public virtual void TakeDamage(int amount)
        {
            Health = Health - amount;
        }
        public void Heal()
        {
            Health = Health + 10;
            Console.WriteLine($"{Health}  Health");
        }
        public void Heal (int amount)
        {
            Health = Health + amount;
            Console.WriteLine($"{Health} Health ");
        }
        public void DisplayHealth()
        {
            Console.WriteLine(Name + "'s health: " + Health);
        }
    }
}
