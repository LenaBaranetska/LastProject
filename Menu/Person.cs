using System;

namespace Menu
{
	public class Person
	{
		public string Name { set; get; }
		public string Surname { set; get; }

		public Person()
		{
			Console.WriteLine("input name: ");
			Name = Console.ReadLine();

			Console.WriteLine("input Surname: ");
			Surname = Console.ReadLine();
		}

		public void Print()
		{
			Console.WriteLine("{0} : {1}", Name, Surname);
		}

	}
}
