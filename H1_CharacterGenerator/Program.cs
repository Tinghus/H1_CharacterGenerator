using H1_CharacterGenerator.Classes;
using System.Globalization;
using static H1_CharacterGenerator.Classes.CharacterClass;

namespace H1_CharacterGenerator
{
    internal class Program
    {

        private static List<CharacterObject> CharacterList = new List<CharacterObject>();
        private static CharacterClass Character = new CharacterClass();

        static void Main(string[] args)
        {
            Console.WriteLine("Character Generator\n");
            GetInput();
            ShowCharacters();
            Console.ReadKey();
        }

        static void ShowCharacters()
        {
            foreach (CharacterObject character in CharacterList)
            {
                Console.Write(Character.ShowCharacter(character));
                Console.Write("\n\n");
            }


        }

        static void GetInput()
        {

            int numberOfCharacters;

            while (true)
            {
                Console.Write("How many characters would you like to create ?: ");

                if (int.TryParse(Console.ReadLine(), out numberOfCharacters) && numberOfCharacters > 0)
                {
                    if (numberOfCharacters > 10)
                    {
                        Console.WriteLine("We are going to be here a while \n\n");
                    }

                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a valid number.\n\n");
                }
            }

            for (int i = 0; i < numberOfCharacters; i++)
            {
                Console.WriteLine($"Creating charater: {i + 1} \n");

                string name, charClass, race;
                DateTime birthday;



                while (true)
                {
                    Console.Write("Name: ");
                    name = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        break;
                    }
                    Console.WriteLine("Name cannot be empty.");
                }

                while (true)
                {
                    Console.Write("Class: ");
                    charClass = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(charClass))
                    {
                        break;
                    }
                    Console.WriteLine("Class cannot be empty.");
                }

                while (true)
                {
                    Console.Write("Race: ");
                    race = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(race))
                    {
                        break;
                    }
                    Console.WriteLine("Race cannot be empty.");
                }

                while (true)
                {
                    Console.Write("Birthday \"yyyy-mm-dd\": ");
                    string input = Console.ReadLine();
                    if (DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthdate))
                    {
                        birthday = birthdate;
                        break;
                    }
                    Console.WriteLine("Invalid date format. Please enter a valid date in the format yyyy-mm-dd");
                }

                StatClass.StatsObject stats = new StatClass.StatsObject();
                CharacterObject character = new CharacterObject(name, charClass, race, birthday, stats);
                CharacterList.Add(character);

                Console.Clear();
                Console.WriteLine("Character Generator\n\n");

            }

        }

    }
}