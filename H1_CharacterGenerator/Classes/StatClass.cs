using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_CharacterGenerator.Classes
{
    internal class StatClass
    {
        private static int RollStat()
        {
            Random diceRoll = new Random();

            return diceRoll.Next(3, 19);
        }

        public class StatsObject
        {
            public int Strength { get; set; }
            public int Dexterity { get; set; }
            public int Constitution { get; set; }
            public int Intelligence { get; set; }
            public int Wisdom { get; set; }
            public int Charisma { get; set; }
            public int AverageStat { get; set; }

            public StatsObject()
            {
                Strength = RollStat();
                Dexterity = RollStat();
                Constitution = RollStat();
                Intelligence = RollStat();
                Wisdom = RollStat();
                Charisma = RollStat();

                AverageStat = Convert.ToInt16((Strength + Dexterity + Constitution + Intelligence + Wisdom + Charisma) / 6);
            }

            public string GetStats(StatsObject stats)
            {
                string output = "\n" +
                    $"Strength: {stats.Strength}\n" +
                    $"Dexterity: {stats.Dexterity}\n" +
                    $"Constitution: {stats.Constitution}\n" +
                    $"Intelligence: {stats.Intelligence}\n" +
                    $"Wisdom: {stats.Wisdom}\n" +
                    $"Charisma: {stats.Charisma}\n";

                return output;
            }

        }

    }
}
