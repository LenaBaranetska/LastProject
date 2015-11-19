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
            Users users = new Users();
            int m;
            do
            {
                Console.WriteLine("_________________");
                Console.WriteLine("1.Add User");
                Console.WriteLine("2.Remove User");
                Console.WriteLine("3.Edit User");
                Console.WriteLine("4.Print User");
                Console.WriteLine("5.Save to File");
                Console.WriteLine("6.Read from DB");
                Console.WriteLine("0.Exit");
                Console.Write("->_");
                int.TryParse(Console.ReadLine(), out m);
                Console.Clear();

                switch (m)
                {
                    case 0: break;
                    case 1:

                        Console.WriteLine("Add User");
                        users.Add();
                        break;
                    case 2:
                        Console.WriteLine("Remove User");
                        users.Remove();
                        break;
                    case 3:
                        Console.WriteLine("Edit User");
                        users.Edit();
                        break;
                    case 4:
                        Console.WriteLine("Print User");
                        users.Print();
                        break;
                    case 5:
                        users.WriteToFile();
                        break;
                    case 6:
                        users.ReadFromDB();
                        break;
                    default:
                        Console.WriteLine("No such Command");
                        break;

                }

            } while (m != 0);
        }
    }
}
