using System;

namespace exampleone
{

	public class Allthatprints
	{

		public static void Main(string[] args)
		{

			Book book1 = new Book();
			Book book2 = new Book();
			Book book3 = new Book();
			Book book4 = new Book();
			Magazine magazine = new Magazine();
			Magazine magazine2 = new Magazine();
			Magazine magazine3 = new Magazine();
			Magazine magazine4 = new Magazine();

			Printable[] printables = new Printable[] { book1, book2, book3, book4, magazine, magazine2, magazine3, magazine4 };


			for (int i = 0; i < printables.Length; i++)
			{

				if (printables[i] is Book)
				{
					Book.printBook(printables);
				}
				else
				{
					Magazine.printMagazines(printables);
				}
			}
		}
	}
	public class Book : Printable
	{

		public virtual void print()
		{
			Console.WriteLine("The book is printed!");
		}

		internal static void printBook(Printable[] printable)
		{
			Console.WriteLine("Title of the Book!" + printable.ToString());
		}

	}
	public class Magazine : Printable
	{
		public virtual void print()
		{
			Console.WriteLine("The Magazine is printed!");
		}

		internal static void printMagazines(Printable[] printable)
		{
			Console.WriteLine("Title of the Magazine! " + printable.ToString());
		}

	}
	public interface Printable
	{

		void print();
	}
}


