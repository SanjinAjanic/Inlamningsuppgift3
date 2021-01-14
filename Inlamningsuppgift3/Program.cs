using System;
using System.Collections.Generic;

namespace Inlamningsuppgift3
{
    class Program
    {
        static void Main(string[] args)
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

            }
        }
        private static void GoAdventure(Player player)
        {
            Console.Clear();
            Random randomNr = new Random();
            int rnumb = randomNr.Next(10);//Ett nummer mellan 0-9

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
            ///Skapat Monster och tilldelat dom med namn, level,hp
            SpecifiktMonster Kimbo = new SpecifiktMonster( 30, 100, "Kimbo");
            SpecifiktMonster Drago = new SpecifiktMonster( 60, 150, "Drago");
            SpecifiktMonster Sardin = new SpecifiktMonster( 80, 200,  "Sardin");
            SpecifiktMonster Bmw = new SpecifiktMonster( 100, 500, "Bmw");
            SpecifiktMonster Muharem = new SpecifiktMonster( 120, 130, "Muharem");
            SpecifiktMonster Fisken = new SpecifiktMonster(150, 10, "Fisken");
            SpecifiktMonster Fisken2 = new SpecifiktMonster(150, 10, "Fisken");
            SpecifiktMonster Fisken3 = new SpecifiktMonster(150, 10, "Fisken");
            SpecifiktMonster Fisken4 = new SpecifiktMonster(150, 10, "Fisken");


            //Skapat en Lista till Monster
            List<SpecifiktMonster> NewMonsters = new List<SpecifiktMonster>();
            //Lagt in alla Monster i listan
            NewMonsters.Add(Fisken);
            NewMonsters.Add(Muharem);
            NewMonsters.Add(Bmw);
            NewMonsters.Add(Sardin);
            NewMonsters.Add(Drago);
            NewMonsters.Add(Kimbo);
            NewMonsters.Add(Fisken2);
            NewMonsters.Add(Fisken3);
            NewMonsters.Add(Fisken4);

            return NewMonsters;
        }
        private static void Fights(int rnumb, Player player)
        {
                List<SpecifiktMonster> monsterList = NewMonsters();
            SpecifiktMonster Tupac = new SpecifiktMonster(monsterList[rnumb].Hp,monsterList[rnumb].Exp,monsterList[rnumb].Name);

            Random randomDamageMonster = new Random();
            Random randomDamagePlayer = new Random();
            do
            {
               
                int damageMonster = randomDamageMonster.Next(7, 14);
                int damagePlayer = randomDamagePlayer.Next(7, 14);
                if (monsterList[rnumb].Name =="Bmw")
                {
                    Console.WriteLine($"Uh oh! A {monsterList[rnumb].Name} appeard!\n" +
                     $"You hit the monster, dealing {damageMonster} damage\n" +
                     $"UUuoooaah *slurp*\n" +
                     $"Bmw körde över dig!!, dealing {damagePlayer} damage ");
                }
                else if (monsterList[rnumb].Name =="Fisken")
                {
                Console.WriteLine($"Uh oh! A {monsterList[rnumb].Name} appeard!\n" +
                    $"You hit the monster, dealing {damageMonster} damage\n" +
                    $"UUuoooaah *slurp*\n" +
                    $"The Fish slap  you, dealing {damagePlayer} damage ");

                }
                else
                {
                    Console.WriteLine($"Uh oh! A {monsterList[rnumb].Name} appeard!\n" +
                   $"You hit the monster, dealing {damageMonster} damage\n" +
                   $"UUuoooaah *slurp*\n" +
                   $"The monster hit you, dealing {damagePlayer} damage ");
                }
                player.Hp -= damagePlayer;
                Tupac.Hp -= damageMonster;
                Console.WriteLine($"{player.Name}: {player.Hp} hp\n" +
                    $"{Tupac.Name}: {Tupac.Hp} hp\n" +
                    $"[Press enter to continue]");
                Console.ReadLine();
                     
            } while (Tupac.Hp >0);
        }
    }
}



