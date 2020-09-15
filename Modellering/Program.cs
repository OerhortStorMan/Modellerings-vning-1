using System;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Player nisse = new Player();
            nisse.name = "Nisse";

            Pet kisse = new Pet();
            kisse.name = "Kisse";

            bool petGotOwner = false;
            bool playerGotPet = false;

            kisse.owner = nisse; 
            petGotOwner = true;

            nisse.pet = kisse;
            playerGotPet = true;

            if (petGotOwner == true)
            {
                System.Console.WriteLine(kisse.name + " har en ägare som heter " + nisse.name);
            }

            Football ball = new Football();

            System.Console.WriteLine("bollen ligger på koordinaterna " + ball.x + ";" + ball.y + ";" + ball.z); 


            Console.ReadLine();

            ModelleringTry2();
            
        }

        static void ModelleringTry2()
        {
            System.Console.WriteLine("Försök 2");

            Player player1 = new Player();

            System.Console.WriteLine("vad ska din spelare heta?");
            string playername = Console.ReadLine();
            player1.name = playername;

            Enemy enemy1 = new Enemy()

            enemy1.hp = 30;
            enemy1.name = "nisse";
            enemy1.damage = 10;


            Weapon sword = new Weapon();

            sword.damage = 15;
            sword.name = "sword";

            System.Console.WriteLine(player1.name + " har ett/en " + sword.name + " som vapen");

            System.Console.WriteLine(player1.name + " är i en fight med " + enemy1.name);
            System.Console.WriteLine(player1.name + " har " + player1.hp + "hp");
            System.Console.WriteLine(enemy1.name + " har " + enemy1.hp + "hp");

            System.Console.WriteLine(player1.name + " slår " + enemy1.name);

            enemy1.hp -= sword.damage;

            System.Console.WriteLine(enemy1.name + " har nu " + enemy1.hp + "hp");

            System.Console.WriteLine(enemy1.name + " slår " + player1.name);

            player1.hp -= enemy1.damage;

            System.Console.WriteLine(player1.name + " har nu " + player1.hp + "hp");

            System.Console.WriteLine("(och forsättning följer, orkar inte skriva för det blir bara slagsmålspel nummer 34352524");
            Console.ReadLine();
        }




    }
}
