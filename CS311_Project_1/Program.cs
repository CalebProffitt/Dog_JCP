using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS311_Project_1
{
	public class Dog
	{

		public int age;
		public String name;

		/**
		 * Empty-argument constructor to put object
		 * into a consistent state.
		 */

		public Dog()
		{
			age = 0;
			name = "";
		}//end constructor

		/**
		 * Constructor accepts the age and
		 * name of the dog. This is the preferred
		 * constructor.
		 * @param age
		 * @param name
		 */
		public Dog(int age, String name)
		{

			this.setAge(age);
			this.setName(name);

		}//end constructor

		public int calcDogYears()
		{
			int dogYears = 15 + (this.age - 1) * 7;
			return dogYears;
		}

		/**
		 * Getter for age
		 * @return
		 */
		public int getAge()
		{
			return age;
		}//end getAge

		/**
		 * Setter for age
		 * Checks the bounds so 
		 * @param age
		 */
		public void setAge(int age)
		{
			if (age < 0)
				this.age = 0;
			else
				this.age = age;
		}//end setAge

		/**
		 * Getter for name
		 * @return
		 */
		public String getName()
		{
			return name;
		}//end getName

		/**
		 * Setter for name. Ensures that only
		 * alpha characters are allowed in the name.
		 * @param name
		 */
		public void setName(String name)
		{
			bool valid = true;
			char[] n = name.ToCharArray();

			foreach (char c in n)
			{
				if (!Char.IsLetter(c))
				{
					valid = false;
					break;
				}
			}

			if (valid)
				this.name = name;
			else
				this.name = "";

		}//end setName

		public override String ToString()
		{
			return "Dog [age=" + age + ", name=" + name + "]";
		}//end toString

	}//end class

	class Program
	{
		private static void Main(String[] args)
		{
			Dog dog = new Dog();
			dog.setAge(4);
			dog.setName("Cheddar");
			int DAge = dog.calcDogYears();
			string ageName = dog.ToString();

			Console.WriteLine("Age of the dog: " + dog.age);
			Console.WriteLine("Name of the dog: " + dog.name);
			Console.WriteLine("Age of the dog in dog years: " + DAge);
			Console.WriteLine("Dog stats using ToString: " + ageName);
			Console.WriteLine("\nPress enter to exit..");
			Console.ReadLine();
		}
	}
}
