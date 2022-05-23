
//puto el que lee
using System;

namespace Ejercicio_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			convertir euro = new convertir();
			
			Console.WriteLine("Convertir euro a dolar");
			Console.WriteLine(euro.conv(128));
			
			Console.Read();
		}
	}
	
	class Circulo
	{
		private const double pi = 3.14159; // propiedad de la clase Circulo. Campo de clase
		
		public double calculoArea(int radio) // metodo de clase. ¿que pueden hacer los objetos de tipo circulo?
		{
			return pi *radio * radio;
		
		}
	}
	class convertir{
	
		private double euro = 1.055546875;
		
		public double conv (double cantidad){
	
			return cantidad * euro;
	}
		public void cambiar (double valor){
			if (valor < 0){
			euro = 1.055546875;
			}
			else{
			euro = valor;
			}
		}
		
	
	}
}
