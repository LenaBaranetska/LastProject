using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Menu
{
	class Person
	{
		string Name { set; get; }
		string Surname { set; get; }

		Person()
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
