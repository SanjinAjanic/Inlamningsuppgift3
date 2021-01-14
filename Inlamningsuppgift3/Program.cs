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
            Player player  = new Player(namn);

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
                Fights(rnumb);
            }

        }
        private static List<Monster> NewMonsters()
        {
            ///Skapat Monster och tilldelat dom med namn, level,hp
            Monster Kimbo = new Monster("Kimbo", 1, 30);
            Monster Drago = new Monster("Drago", 3, 60);
            Monster Sardin = new Monster("Sardin", 5, 80);
            Monster Bmw = new Monster("Bmw", 7, 100);
            Monster Muharem = new Monster("Muharem", 10, 120);
            Monster Fisken = new Monster("Fisken", 15, 150);
            Monster Fisken2 = new Monster("Fisken", 15, 150);
            Monster Fisken3 = new Monster("Fisken", 15, 150);
            Monster Fisken4 = new Monster("Fisken", 15, 150);


            //Skapat en Lista till Monster
            List<Monster> NewMonsters = new List<Monster>();
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
        private static void Fights(int rnumb)
        {
            Console.WriteLine("Fight");
            List<Monster> monsterList = NewMonsters();
            Console.WriteLine(monsterList[rnumb].Name);
        }
    }
}



