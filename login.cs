using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_fall_1
{
    class login
        // Här ska lösenord / Användarnamn kollas så att dom är ok. annars ska undantag kastas.
    {
        private string _Username = "Admin"; //Användarnamnet sätts till "Admin"
        private string _Password = "Admin"; //Lösenordet sätts till "Admin"
        private bool _isuserloggedin = false; //Boolen som ska kolla om man har lyckats logga in sätts till false

        public void loggingIn(string Username, string Password) // Tar vad användaren har matat in och kollar mot dom hårdkodade värderna. 
        {
            if (Username != _Username || Password != _Password) //om det inte matchar
            {
                throw new ArgumentException(); //Kasta undantag
            }
            else //Annars har inlogget lyckats
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("att logga in lyckades\n");
                Console.ResetColor();
                isUserLoggedIn = true; //Värdet sätts till true, applikationen kommer inte att köras igen
                return;
        }
        public void LoggedOut() //Check för att se om man är inloggad
        { 
            isUserLoggedIn = false; //False = icke inloggad
        }

        public void userloginInput(bool loggedin)
        { 
        if (loggedin == false) //Om ovanstående boolean är false ska man testa att logga in
            {
                try
                { 
                    Console.Write("Användarnamn: ");
                    string Username = Console.ReadLine();
                    Console.Write("Lösenord: ");
                    string Password = Console.ReadLine();

                    loggingIn(Username, Password);
                }
                catch //Undantaget som kastas ovan.
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Fel användarnamn eller lösenord :[ Programmet stängs av!");
                    Console.ResetColor();
                    loggedin = false;
                }
            }
        }
        public bool isUserLoggedIn
        {
            get
            {
                return _isuserloggedin;
            }
            set
            {
                _isuserloggedin = value;
            }
        } 
   }
}
