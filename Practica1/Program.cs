/*
 * Created by SharpDevelop.
 * User: User
 * Date: 05/09/2024
 * Time: 16:03
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Practica1
{
	class Program
	{
		public static void Main(string[] args)
		{
			Pila<Numero> pila= new Pila<Numero>();
			Cola<Numero> cola= new Cola<Numero>();
			ColeccionMultiple multiple= new ColeccionMultiple(pila,cola);
			llenarPersona(pila);
			llenarPersona(cola);
			informar(multiple);
			llenar(pila);
			llenar(cola);
			informar(pila);
			informar(cola);
			llenarAlumnos(pila);
			llenarAlumnos(cola);
			
			
			
		
				
			
		}
		
		
		public static void llenar(Coleccionable a){
			Random random = new Random();
			for (int i = 0; i < 20; i++) {
				int valorAlAzar= random.Next(1,101);
				Numero comparable= new Numero(valorAlAzar);
				a.agregar(comparable);
				
			}
			
		}
		
		public static void informar(Coleccionable a){
			Console.WriteLine(a.Cuantos());
			Console.WriteLine(a.minimo());
			Console.WriteLine(a.maximo());
			Console.WriteLine("Escriba un numero: ");
			int valores= int.Parse(Console.ReadLine());
			Numero comparable= new Numero(valores);
			if (a.contiene(comparable)) {
				Console.WriteLine("El elemento leido esta en la coleccion");
			}
			else{
				Console.WriteLine("El elemento leido no esta en la coleccion");
			}
		}
		
		public static void llenarPersona(Coleccionable a){
			string abecedario= "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
			Random rand= new Random();
			for (int i = 0; i < 20; i++) {
				string nomAlAzar=abecedario[rand.Next(abecedario.Length)].ToString();
				int dniAlAzar=rand.Next(10000000, 99999999);
				Persona compara =new Persona(nomAlAzar,dniAlAzar);
				a.agregar(compara);
			}
			
		}
		
		
		public static void llenarAlumnos(Coleccionable a){
			string abec="ABCDEFGHIJKLMNÑOPQRSTUVWXYZ";
			Random randm= new Random();
			for (int i = 0; i < 20; i++) {
				string nombreAzar=abec[randm.Next(abec.Length)].ToString();
				int dniAzar=randm.Next(10000000,99999999);
				int legajo=randm.Next(1000,9999);
				double promedio=Math.Round(randm.NextDouble()*10,2);
				Alumno com= new Alumno(nombreAzar,dniAzar,legajo,promedio);
				a.agregar(com);
			}
		}
	}
	
	
}