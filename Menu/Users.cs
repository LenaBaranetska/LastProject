using System;
using System.Collections.Generic;

namespace Menu
{
	public class Users
	{
		List<Person> users = new List<Person>();

		public void Add()
		{
			users.Add(new Person());
        }

		public void Edit()
		{
			var id = Find();

			if (id >= 0)
			{
				var person = users[id];
				bool menu = true;

				while(menu)
				{
					Console.Clear();
					person.Print();
                    Console.WriteLine("1 - edit name");
					Console.WriteLine("2 - edit surname");
					Console.WriteLine("3 - exit");
					string choice = Console.ReadLine();

					switch(choice)
					{
						case "1":
							Console.WriteLine("old name: {0}", person.Name);
							person.Name = Console.ReadLine();
                            break;

						case "2":
							Console.WriteLine("old surname: {0}", person.Surname);
							person.Surname = Console.ReadLine();
							break;

						case "3":
							menu = false;
							Console.Clear();
							break;
					}
				}

			}
			else
			{
				Console.WriteLine("no such person!");
			}

		}

		public void Remove()
		{
			var id = Find();
			if (id >= 0)
			{
				users.Remove(users[id]);
				Console.WriteLine("done!");
			}
			else
			{
				Console.WriteLine("no such person!");
			}
		}

		private int Find()
		{
			Console.WriteLine("input user surname: ");
			string surname = Console.ReadLine();
			
			for(int i =0; i < users.Count; i++)
			{
				if (users[i].Surname == surname)
				{
					return i;
				}
			}
			return -1;
		}

		public void Print()
		{
			foreach(var person in users)
			{
				person.Print();
			}
		}
	}
}
