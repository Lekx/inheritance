using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class life
    {
        public string welcomeMessage;

        public life()
        {
            this.welcomeMessage = "Hello there, I am a baby dinosaur ";
        }

        public void newBorn() 
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("-GOD:...and by my OWN power, I create this dinosaur being!!");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++");
            newBeing();
        
        }



        public void newBeing() 
        {
            Console.WriteLine("\n\t        " + welcomeMessage);
            Console.WriteLine("\t\t\t               /");
            Console.WriteLine("\t\t		 ▄▄▄▄▄▄▄▄▄▄▄▄");
            Console.WriteLine("\t\t		███ | ████████");
            Console.WriteLine("\t\t		██████████████");
            Console.WriteLine("\t\t		████████");
            Console.WriteLine("\t\t		████████████");
            Console.WriteLine("\t\t    ▄ 	       ████████");
            Console.WriteLine("\t\t    ▀█	      █████████▀▀█");
            Console.WriteLine("\t\t     ██	     ██████████");
            Console.WriteLine("\t\t      ██▄   ███████████");
            Console.WriteLine("\t\t       ███▄███████████      ");
            Console.WriteLine("\t\t        █████████████████▄▄ █");
            Console.WriteLine("\t\t         ▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀");
        }

    }
}
