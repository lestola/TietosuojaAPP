using System;

namespace TietosuojaApp3
{
	public class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Person()
		{
			// this is the default constructor that JSONFX wanted.
		}

		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
	}

}
