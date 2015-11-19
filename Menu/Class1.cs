using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Menu
{
   public static class Class1
    {
        static void Main()
        {
            Console.WriteLine("Hello Menu");

           MainMenu();
        }
       
       public static void MainMenu()
        {
         int m;
         do
         {
             Console.Clear();
             Console.WriteLine("1.Add User");
             Console.WriteLine("2.Remove User");
             Console.WriteLine("3.Edit User");
             Console.WriteLine("4.Print User");
             Console.WriteLine("5.Find User");
             Console.WriteLine("0.Exit");
             Console.Write("->_");
            int.TryParse(Console.ReadLine(), out m);
            switch (m)
            {
                case 0: break;
                case 1:
                    
                    Console.WriteLine("Add User");
                    Thread.Sleep(2000);
                    break;
                case 2:
                    Console.WriteLine("Remove User");
                    Thread.Sleep(2000);
                    break;
                case 3:
                    Console.WriteLine("Edit User");
                    Thread.Sleep(2000);
                    break;
                case 4:
                    Console.WriteLine("Print User");
                    Thread.Sleep(2000);
                    break;
                case 5:
                    Console.WriteLine("Find User");
                    Thread.Sleep(2000);
                    break;

                default:
                    Console.WriteLine("No such Command");
                    Thread.Sleep(2000);
                    break;

            }

         } while (m != 0);
         }
    }
}
