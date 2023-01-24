using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace H1_CharacterGenerator.Classes
{
    internal class CharacterClass
    {

        public string ShowCharacter(CharacterObject character)
        {
            string output =
                $"Name: {character.Name}\n" +
                $"Class: {character.CharClass}\n" +
                $"Race: {character.Race}\n" +
                $"Level: {character.Level}\n" +
                $"Birthday: {character.Birthday.ToShortDateString()}\n" +
                $"Age: {character.CalculateAge()}";

            output += character.Stats.GetStats(character.Stats);

            return output;
        }


        public class CharacterObject
        {
            public string Name { get; set; }
            public string CharClass { get; set; }
            public string Race { get; set; }
            public int Level { get; set; }
            public DateTime Birthday { get; set; }
            public StatClass.StatsObject Stats { get; set; }

            public CharacterObject(string name, string charClass, string race, DateTime birthday, StatClass.StatsObject stats)
            {
                Name = name;
                CharClass = charClass;
                Race = race;
                Level = stats.AverageStat;
                Birthday = birthday;
                Stats = stats;
            }

            public int CalculateAge()
            {
                int age = DateTime.Today.Year - Birthday.Year;

                return age = Birthday.Date < DateTime.Today.Date ? age - 1 : age;
            }

        }

    }
}
