namespace Console1
{
	public class Animal
	{
		public string Name{get;set;}

		public int Age{get;set;}

		public Animal(string name, int age)
		{
			Name = name;
			Age = age;
		}

		public override string ToString() => $"this {Name} is {Age} years old";
	}
}