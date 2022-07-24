using System;
using desafio_dotnet_dio.src.entities;

namespace desafio_dotnet_dio
{
    class Program{

        static void Main (string[] args)
        {
            Knight arus = new Knight("Arus", 30,"knight");
            
            Wizards wizard = new Wizards ("Jennica", 100, "Wizard" );

            Ninja temura = new Ninja ("Temu-ra", 100, "Ninja" );

            BlackWizard tepapa = new BlackWizard ( "Tepapa",80, "BlackWizard");
    

            Console.WriteLine(arus.attack());
            Console.WriteLine(wizard.attack(10));
            Console.WriteLine(temura.attack());
            Console.WriteLine(tepapa.attack());


      


        }
    }
}


