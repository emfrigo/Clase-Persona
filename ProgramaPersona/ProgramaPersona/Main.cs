using System;

namespace ProgramaPersona
{
	class MainClass
	{ 

		public static void Main (string[] args)
		{
			Persona persona = new Persona();

			Console.Write("Favor de Capturar los datos \nNombre: ");
			persona.nombre = Console.ReadLine();
			Console.Write("Edad: ");
			persona.edad = Convert.ToInt32(Console.ReadLine());
			Console.Write("Correo: ");
			persona.correo = Console.ReadLine();

			Console.WriteLine("Nombre: " + persona.nombre +"\nEdad: " + persona.edad + "\nCorrero: " + persona.correo);
		}
	}
}
