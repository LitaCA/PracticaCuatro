using System;

namespace PracticaProducto
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("\tPRODUCTOS\n");
			
			Console.WriteLine("\tLista de productos ");
			
			string[] producto = new string[3];
			string[] codigo = new string[3];
			string[] descr = new string[3];
			
			for (int x=0; x<3; x++){
				
				Console.WriteLine("\nIngresa el NOMBRE del producto: ");
				producto[x]=Console.ReadLine();
				    
				Console.WriteLine("Ingresa el CÓDIGO del producto: ");
				codigo[x]=Console.ReadLine();
					
				Console.WriteLine("Ingresa la DESCRIPCIÓN del producto: ");
				descr[x]=Console.ReadLine();
				
			}
			
			Console.WriteLine("\n******************************\n ");
			Console.WriteLine("\nLos productos ingresados son:\n ");
			for (int x=0; x<3; x++)
			{
				Console.WriteLine("Producto: " +producto[x] + 
				                  "\nCódigo: "+codigo[x] + 
				                  "\nDescripción: "+descr[x]);
				
				Console.WriteLine("\n"); 		
			}
				
			Console.Write("Presiona una tecla para salir del programa... ");
			Console.ReadKey(true);
		}
	}
}