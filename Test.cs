using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_fall_1
{
    class Test
    {
        public static void Run() 
        {
            Console.WriteLine("         ============================================================");
            Console.WriteLine("         |                   TESTER AV FUNKTIONER                   |");
            Console.WriteLine("         |                    _________________                     |");
            Console.WriteLine("         ============================================================\n");            
            
            testuser(); //Startar testuser
            logintest(); //Startar logintest
        }
        static void logintest() //Här körs alla test för Login-klassen körs i logisk ordning (logga in först, anmäla användare efter)
        {
            if(testlogin1()) //Svar på test om fel användarnamn
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Gick inte att logga in med fel användarnamn!\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("något gick snett, man loggade in med fel användarnamn");
                Console.ResetColor();
            }

            if (testlogin2()) //Svar på test om fel Lösenord
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Gick inte att logga in med fel lösenord!\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("man kom in med fel lösenord :(");
                Console.ResetColor();
            }

            if (testlogin3()) //Svar på test om fel användarnamn och lösenord
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Man kom inte in med fel användarnamn och lösenord!\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Man kom in med fel användarnamn / lösen av någon anledning, Error :(");
                Console.ResetColor();
            }

            if (testlogin4()) //Svar på test om korrekt användarnamn o lösen
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Man kom  in med rätt användarnamn och lösenord!\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Man kom in inte in med rätt användarnamn / lösen av någon anledning, Error :(");
                Console.ResetColor();
            }

        }
        static void testuser() // här "körs" alla test för adduser-klassen
        {
            if (usertest1())
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Lyckat! att anmäla 10 personer gick bra\n");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Fungerar inte, Antal användare gick inte att registrera");
                Console.ResetColor();
            }
        }
        static bool testlogin1() //Testar fel användarnamn
        {
            login testlogin = new login();
            Console.WriteLine("Loggar in med fel användarnamn");
            try
            {
                testlogin.loggingIn("användarnamn", "Admin");
                return false;
            }
            catch
            {
                return true;
            }
        }
        static bool testlogin2() //Testar fel lösenord
        {
            Console.WriteLine("Loggar in med fel Lösenord");
            login testlogin = new login();
            try
            {
                testlogin.loggingIn("Admin", "Lösenord");
                return false;
            }
            catch
            {
                return true;
            }
        }
        static bool testlogin3() // Testar fel användarnamn OCH lösenord
        {
            Console.WriteLine("Loggar in med fel användarnamn och lösenord");
            login testlogin = new login();
            try
            {
                testlogin.loggingIn("användarnamn", "Lösenord");
                return false;
            }
            catch
            {
                return true;
            }
        }
        static bool testlogin4() // Testar korrekta loginuppgifter.
        {
            Console.WriteLine("Loggar in med rätt användarnamn och lösenord");
            login testlogin = new login();
            try
            {
                testlogin.loggingIn("Admin", "Admin");
                return true;
            }
            catch
            {
                return true;
            }
        }
        static bool usertest1() //Testar att lägga till 10 användare
        {
            Console.WriteLine("Test av registrering av 10 användare");
            AddUser AddUser = new AddUser();
            AddUser.UserInput = 10;

            AddUser.addUser();

            if (AddUser.UserInput < AddUser.maximumUsers)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
