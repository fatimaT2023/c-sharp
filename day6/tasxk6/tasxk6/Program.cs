using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace tasxk6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("Ali", 50);

            HealthPotion potion = new HealthPotion();
            potion.PotionNmae = "Healing Potion";

            potion.Collect();

            potion.use(warrior, "15");   // Health: 65
            potion.use(warrior, "abc");  // رسالة خطأ، والبرنامج بكمل

            Console.WriteLine("===== ADVENTURE GAME =====");

            Warrior warrior1 = new Warrior("Alex", 80);
            Wizard wizard = new Wizard("Luna", 70);
            GameCharactercs[] characters = { warrior, wizard };

            foreach (GameCharactercs character in characters)
            {
                Console.WriteLine("\n" + character.Name + " enters the game!");

                character.UsespecialAbililty();
                character.TakeDamage(10);
                character.DisplayHealth();

                Console.WriteLine("\nAlex heals 10 points.");
                warrior.Heal();

                Console.WriteLine("\nAlex heals 15 points.");
                warrior.Heal(15);

                HealthPotion potion1 = new HealthPotion();
                potion.PotionNmae = "Health Potion";

                Console.WriteLine();
                potion.Collect();

                potion.use(wizard, "15");
                potion.use(wizard, "abc");

                Console.ReadLine();
            }

        }
        }
    }

