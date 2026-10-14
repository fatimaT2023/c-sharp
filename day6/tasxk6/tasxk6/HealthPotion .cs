using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasxk6
{
    internal class HealthPotion: ICollectible
    {
        public string PotionNmae { get; set; }
        public void Collect()
        {
            Console.WriteLine(PotionNmae + " collected");
        }
        public void use (GameCharactercs character ,string amountText)
        {
            try
            {
                int amount = Convert.ToInt32(amountText);
                character.Heal(amount);
            }

            catch(FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number.");

            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The number is too large or too small.");
            }
        }
    }
}
