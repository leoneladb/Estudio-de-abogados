/*
 * Creado por SharpDevelop.
 * Usuario: Argentina
 * Fecha: 21/05/2022
 * Hora: 1:19
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;

namespace P2
{
	class Program
	{
		public static void Main(string[] args)
		{
			Coche auto = new Coche(); // crear objeto // instacia de tipo coche.  //auto 1
			//dar un objeto inicial a nuestro coche.
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("auto 1");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(auto.GetInfoCoche()); 
			Console.WriteLine("Ingrese ancho: ");
			double ancho = double.Parse(Console.ReadLine());
			Console.WriteLine("Ingrese largo");
			double largo = double.Parse(Console.ReadLine());
			
		
			Coche auto2 = new Coche(largo, ancho);//auto 2
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("auto 2");
		    Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(auto2.GetInfoCoche()); 
			
			
			
			Coche auto3 = new Coche(); // auto 3
			Console.WriteLine("ingrese tipo de tapiceria");
			string tapiceria = Console.ReadLine();
			bool climatizador= true;
			auto3.setextras(climatizador,tapiceria );
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("auto 3");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(auto3.GetInfoCoche());
			
			
			Coche auto4 = new Coche();
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("auto 4");
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine(auto4.GetInfoCoche());
			Console.Read();
		}
	}
	class Coche{
	
		private int ruedas;
		
		private double largo;
		
		private double ancho;
		
		private bool climatizador;
		
		private string tapiceria;
		
		public Coche(){
		
			ruedas = 4;
			largo = 2300.5;
			ancho = 0.800;
		
		}
		public Coche(double Nuevolargo, double Nuevoancho)
		{
			
			ruedas = 4;
			largo = Nuevolargo;
			ancho = Nuevoancho;
					
		
		
		}
		
		
		public string GetInfoCoche ()
		{
			
				return "informacion del coche: Ruedas:"+ruedas+" largo: "+largo+" ancho: "+ancho+" climatizador "+climatizador+ " tapiceria: " + tapiceria ;
		}
		
		public void setextras(bool paraClimatizador, string paraTapicaria)
		{
			climatizador = paraClimatizador;
			tapiceria = paraTapicaria;
		
		}
		public string getextras ()
		
		{
			return "Extras del coche \n"+"climatizador: "+climatizador+ "\ntapiceria: "+ tapiceria;
		}
		
		
		
	
		
	
	}
}