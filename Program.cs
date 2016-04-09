using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Program
    {
        private const int MIN_DICE_ROLL = 1;
        private const int MAX_DICE_ROLL = 6;
        private const int TOTAL_ROLLS = 10;

        static void Main(string[] args)
        {
            var random = new Random();

            var list1 = RollDice(TOTAL_ROLLS, random);
            var list2 = RollDice(TOTAL_ROLLS, random);

            IEnumerable<int> CompareRolls = list1.Except(list2);
            foreach (var item in CompareRolls)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }

        private static List<int> RollDice(int totalRolls, Random randomGenerator)
        {
            var rollTotal = new List<int>();

            for (int index = 0; index < totalRolls; index++)
            {
                var roll1 = RollDice(randomGenerator);
                var roll2 = RollDice(randomGenerator);
                
                rollTotal.Add(roll1 + roll2);
            }

            return rollTotal;
        }

        private static int RollDice(Random randomGenerator)
        {
            return randomGenerator.Next(MIN_DICE_ROLL, MAX_DICE_ROLL + 1);
        }
    }
}
