using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_fall_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Analyserat användningsfall, se laborationspappret labb 3 för mer specifikationer
            Integrationtests integrationtest = new Integrationtests();
            integrationtest.integrationstester();

            Test.Run(); //Startar testklassen och kör testerna

            Console.WriteLine("         ============================================================");
            Console.WriteLine("         |                    Hej och välkommen!                    |");
            Console.WriteLine("         |                 Var vänlig och Logga in!                 |");
            Console.WriteLine("         ============================================================\n");

            logon(false);
        }
        static void logon(bool loggedin) 
        {
            login login = new login(); //Startar en ny loginklass
            AddUser AddUser = new AddUser(); //Startar en ny AddUser klass

            login.userloginInput(loggedin); // kör userloginInput i Login-klassen

            if (login.isUserLoggedIn == true) //Om man lyckas logga in 
            {
                int UserChoice; //Körs detta
                UserChoice = userInput("Väj ett alternativ:\n0: anmäl antal deltagare Annat alernativ stänger av\n");
                if(UserChoice == 0)
                {
                    Console.WriteLine("Ange antal personer som är på träningen (20 max)");
                    AddUser.UserInput = int.Parse(Console.ReadLine());
                    AddUser.addUser(); //Startar adduser i adduser-klassen.
                    
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Fel!\nInget nummer inom intervallet angavs, programmet stängs av!");
                    Console.ResetColor(); //Anger man fel stänger man an
                }
            }
        }

        public static int userInput(string prompt) // För att se vad användaren matar in. /för att det ska tolkas. <- Till menyvalet 
        {
            while(true)
            {
                try
                {
                    Console.WriteLine(prompt);
                    int input = int.Parse(Console.ReadLine());
                    return input;
                }
                catch //Men om man matar in något annat en en siffra
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Error inget nummer angavs");
                    Console.ResetColor();
                }
            }
        }
    }
}
