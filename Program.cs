using System;

namespace Ejercicio2DeSantiagoLeguizamonn
{
	class Program
	{
		static void Main(string[] args)
		{
			double area;
			double ladoa;
			double ladob;
			double ladoc;
			double p;
			double perimetro;
			Console.Write($"Ingrese la medida del primer lado: ");
			ladoa = Double.Parse(Console.ReadLine());
			Console.Write($"Ingrese la medida del segundo lado: ");
			ladob = Double.Parse(Console.ReadLine());
			Console.Write($"Ingrese la medida del tercer lado: ");
			ladoc = Double.Parse(Console.ReadLine());
			p = (ladoa + ladob + ladoc) / 2;
			area = Math.Sqrt(p * (p - ladoa) * (p - ladob) * (p - ladoc));
			perimetro = ladoa + ladob + ladoc;
			if (verificartriangulo(ladoa, ladob, ladoc))
			{
				if (Math.Pow(ladoa, 2) == (Math.Pow(ladob, 2) + Math.Pow(ladoc, 2)))
				{
					Console.WriteLine("el triangulo es rectángulo");
				}
				else
				{
					if (Math.Pow(ladoa, 2) > (Math.Pow(ladob, 2) + Math.Pow(ladoc, 2)))
					{
						Console.WriteLine("el triangulo es obtusángulo");
					}
					else
					{
						if (Math.Pow(ladoa, 2) < (Math.Pow(ladob, 2) + Math.Pow(ladoc, 2)))
						{
							Console.WriteLine("el triangulo es acutangulo");
						}
					}
				}
				Console.WriteLine($"El perimetro del triangulo es: {perimetro}");
				Console.WriteLine($"La superficie del triangulo es: {area} ");
			}
			else
			{
				Console.WriteLine("Las medidas ingresadas no conforman un triangulo");
			}
		}
		private static bool verificartriangulo(double ladoa, double ladob, double ladoc)
		{
			bool trianguloverificado;
			trianguloverificado = (ladoa + ladob > ladoc) && (ladoa + ladoc > ladob) && (ladob + ladoc > ladoa);
			return trianguloverificado;
		}
	}
}