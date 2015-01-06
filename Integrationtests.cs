using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_fall_1
{
    class Integrationtests
    {
        public void integrationstester()
        {
            Console.Clear();
            Console.WriteLine("         ============================================================");
            Console.WriteLine("         |                    ITEGRATIONSTESTER                     |");
            Console.WriteLine("         |                    _________________                     |");
            Console.WriteLine("         ============================================================\n");
            if(logintest1())
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen; //resultat på att man inte har loggat in
                Console.WriteLine("_isuserloggedin = false, fungerar!\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("_isuserloggedin:s värde har inte bytts, något är fel\n");
                Console.ResetColor();
            }

            if(logintest2()) //Resultat på att man HAR loggat in
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("_isuserloggedin byttes till true efter att man har loggat in, fungerar! \n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Trots att man har angett rätt upgifter kommer man inte in, fungerar ej \n");
                Console.ResetColor();
            }

            if(logintest3()) //Resultat på att man försöker logga in med fel uppgifter
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("_isuserloggedin:s värde byttes inte vid felaktigt inlogg, Fungerar!\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("_isuserloggedin:s värde byts TROTS fel uppgifter = Man loggar in med fel grejer , fungerar inte\n");
                Console.ResetColor();
            }

            if (usertest1()) //Resultat på att lägga till användare under maxgränsen
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Userinput resetade, fungerar\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("UserInputs värde återställdes inte, fungerar inte\n");
                Console.ResetColor();
            }
        }
        static bool logintest1()
        {
            Console.WriteLine("integrationstest nr.1 status på _isuserlogged in utan att man har loggat in\n");
            login testlogin = new login();
            try
            {
                if (testlogin.isUserLoggedIn == false)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        static bool logintest2()
        {
            Console.WriteLine("integrationstest nr.2 status på _isuserlogged EFTER att man har loggat in\n");
            login testlogin = new login();
            try
            {
                testlogin.loggingIn("Admin", "Admin");
                if (testlogin.isUserLoggedIn == true)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return false;
            }
        }

        static bool logintest3()
        {
            Console.WriteLine("integrationstest nr.3 status på _isuserlogged EFTER att man har loggat in med fel uppgifter\n");
            login testlogin = new login();
            try
            {
                testlogin.loggingIn("Fel", "Uppgifter");
                if (testlogin.isUserLoggedIn == false)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return true;
            }
        }

        static bool usertest1()
        {
            Console.WriteLine("integrationstest nr.4 kollar om userinput resetar efter en lyckad anmälning skickar in 5 användare\n");
            AddUser Testuser = new AddUser();
            try
            {
                Testuser.UserInput = 5;
                Testuser.addUser();
                if (Testuser.UserInput == 0)
                {
                    return true;
                }
                else
                    return false;
            }
            catch
            {
                return true;
            }
        }
    }
}
