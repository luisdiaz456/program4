using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
	public class Libro
	{
		public string Titulo { get; set; }
		public string Autor { get; set; }

		public override string ToString()
		{
			return $"Título: {Titulo}, Autor: {Autor}";
		}
	}

	public class Biblioteca
	{
		private List<Libro> libros = new List<Libro>();

		public void AgregarLibro(Libro libro)
		{
			libros.Add(libro);
		}

		public void MostrarLibros()
		{
			if (libros.Count == 0)
			{
				Console.WriteLine("No hay libros en la biblioteca.");
			}
			else
			{
				Console.WriteLine("Libros en la biblioteca:");
				foreach (var libro in libros)
				{
					Console.WriteLine(libro);
				}
			}
		}
	}

	public class ProgramaBiblioteca
	{
		public static void Main(string[] args)
		{
			Biblioteca biblioteca = new Biblioteca();

			while (true)
			{
				Console.WriteLine("\nMenú:");
				Console.WriteLine("1. Agregar libro");
				Console.WriteLine("2. Mostrar libros");
				Console.WriteLine("3. Salir");
				Console.Write("Ingrese la opción: ");

				string opcion = Console.ReadLine();

				switch (opcion)
				{
					case "1":
						AgregarLibro(biblioteca);
						break;
					case "2":
						biblioteca.MostrarLibros();
						break;
					case "3":
						return;
					default:
						Console.WriteLine("Opción no válida.");
						break;
				}
			}
		}

		public static void AgregarLibro(Biblioteca biblioteca)
		{
			Console.Write("Título del libro: ");
			string titulo = Console.ReadLine();

			Console.Write("Autor del libro: ");
			string autor = Console.ReadLine();

			Libro libro = new Libro { Titulo = titulo, Autor = autor };
			biblioteca.AgregarLibro(libro);

			Console.WriteLine("Libro agregado.");
		}
	}
}
