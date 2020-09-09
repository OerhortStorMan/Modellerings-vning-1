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
                System.Console.WriteLine(nisse.pet + " har en ägare som heter " + kisse.owner);
            }


            Console.ReadLine();

            
        }
    }
}
