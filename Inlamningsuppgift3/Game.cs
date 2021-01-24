using System;
using System.Collections.Generic;
using System.Text;

namespace Inlamningsuppgift3
{
    class Game
    {
        public void Start()
        {
            Console.Title = "Sanjins Inlämningsuppgift3";
            

            Console.WriteLine("**********************");
            Console.WriteLine("* Welcome to the game*");
            Console.WriteLine("**********************");


            Console.Write("Enter your name: ");
            string namn = Console.ReadLine();
            Player player = new Player(namn);

            Meny(player);
        }

        private static void Meny(Player player)
        {
            string input = "";
            int userInPut = 0;
            bool IsNum = false;
            bool exit = false;
            do
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine("1. Go adventuring");
                    Console.WriteLine("2. Show details about your character");
                    Console.WriteLine("3. Exit game");
                    input = Console.ReadLine();
                    IsNum = int.TryParse(input, out userInPut);

                } while (IsNum == false);

                switch (userInPut)
                {
                    case 1:
                        GoAdventure(player);
                        break;
                    case 2:
                        ShowDetails(player);
                        break;
                    case 3:
                        Console.WriteLine("Bye bye!");
                        exit = true; 
                        break;
                    default:
                        break;

                }

            } while (!exit);
        }

        private static void ShowDetails(Player player)
        {
            Console.WriteLine("********************");
            Console.WriteLine($"* Name: {player.Name}");
            Console.WriteLine($"* Level: {player.Level}");
            Console.WriteLine($"* HP: {player.Hp}/{player.MaxHp}");
            Console.WriteLine($"* Exp: {player.Exp}/{player.MaxExp}");
            Console.WriteLine("********************");
            Console.ReadKey(true);
        }

        private static void GoAdventure(Player player)
        {
            Console.Clear();
            Random randomNr = new Random();
            int rnumb = randomNr.Next(10); //Ett nummer mellan 0-9

            if (rnumb == 9)
            {
                Console.WriteLine("You see nothing but swaying grass all around you...\n[Press enter to continue.] ");
                Console.ReadLine();
            }
            else
            {
                Fights(rnumb, player);
            }

        }

        private static List<SpecifiktMonster> NewMonsters()
        {
            List<SpecifiktMonster> monsters = new List<SpecifiktMonster>()
            {
                new SpecifiktMonster(150, 10, "Fisken"),
                new SpecifiktMonster( 120, 130, "Muharem"),
                new SpecifiktMonster(150, 10, "Fisken"),
                new SpecifiktMonster( 100, 500, "Bmw"),
                new SpecifiktMonster(150, 10, "Fisken"),
                new SpecifiktMonster( 80, 200,  "Sardin"),
                new SpecifiktMonster(150, 10, "Fisken"),
                new SpecifiktMonster(60, 150, "Drago"),
                new SpecifiktMonster(150, 10, "Fisken"),
                new SpecifiktMonster( 30, 100, "Kimbo")
            };

            return monsters;
        }

        private static void Fights(int rnumb, Player player)
        {
            List<SpecifiktMonster> monsterList = NewMonsters();
            SpecifiktMonster Tupac = new SpecifiktMonster(monsterList[rnumb].Hp, monsterList[rnumb].Exp, monsterList[rnumb].Name);

            Random randomDamageMonster = new Random();
            Random randomDamagePlayer = new Random();
            do
            {

                int damageToMonster = randomDamageMonster.Next(50, 100);
                int damageToPlayer = randomDamagePlayer.Next(7, 14);
                if (monsterList[rnumb].Name == "Bmw")
                {
                    Console.WriteLine($"Uh oh! A {monsterList[rnumb].Name} appeard!\n" +
                     $"You hit the monster, dealing {damageToMonster} damage\n" +
                     $"UUuoooaah *slurp*\n" +
                     $"Bmw körde över dig!!, dealing {damageToPlayer} damage ");
                }
                else if (monsterList[rnumb].Name == "Fisken")
                {
                    Console.WriteLine($"Uh oh! A {monsterList[rnumb].Name} appeard!\n" +
                        $"You hit the monster, dealing {damageToMonster} damage\n" +
                        $"UUuoooaah *slurp*\n" +
                        $"The Fish slap  you, dealing {damageToPlayer} damage ");
                }
                else
                {
                    Console.WriteLine($"Uh oh! A {monsterList[rnumb].Name} appeard!\n" +
                   $"You hit the monster, dealing {damageToMonster} damage\n" +
                   $"UUuoooaah *slurp*\n" +
                   $"The monster hit you, dealing {damageToPlayer} damage ");
                }
                player.Hp -= damageToPlayer;
                Tupac.Hp -= damageToMonster;
                Console.WriteLine($"{player.Name}: {player.Hp} hp\n" +
                    $"{Tupac.Name}: {Tupac.Hp} hp\n" +
                    $"[Press enter to continue]");
                Console.ReadLine();

                if (Tupac.Hp <= 0)
                {
                    Console.WriteLine("You killed the monster! Yeay!");
                    Console.ReadLine();
                    player.Exp += monsterList[rnumb].Exp;

                    if (player.Exp >= player.MaxExp)
                    {
                        player.LevelUp();
                    }
                }

            } while (Tupac.Hp > 0);
        }
    }
}
