using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterativ_fall_1
{
    class AddUser
    {
        public int maximumUsers = 20;
        public int UserInput;
        public void addUser()
        {
          if(UserInput > 0)
          {
            
                    if (UserInput < maximumUsers) //Kollar om vad användaren matar in är mindre än maxantalet isåfall gör nedanstående
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("Tack! {0} användare är nu registrerade", UserInput);
                        Console.ResetColor();
                        UserInput = 0;
                        
                    }
                    else //Om man matar in ett för stort värde 
                    {
                        Console.BackgroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("Fel! 20 eller färre deltagare enbart! Programmet stängs nu av!");
                        Console.ResetColor();
                    }
          }
          else //Om man matar in ett för litet värde 
          {
              Console.BackgroundColor = ConsoleColor.DarkRed;
              Console.WriteLine("Fel! mer än 0 personer måste delta! Programmet stängs nu av!");
              Console.ResetColor();
          }
        }
    }
}
