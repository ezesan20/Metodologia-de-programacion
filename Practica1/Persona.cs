/*
 * Created by SharpDevelop.
 * User: User
 * Date: 12/09/2024
 * Time: 22:35
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica1
{
	/// <summary>
	/// Description of Persona.
	/// </summary>
	public class Persona:IComparable
	{
		private string nombre;
		private int dni;
		
		public Persona(string nombre, int dni)
		{
			this.nombre=nombre;
			this.dni=dni;
		}
		
		public string getNombre(){
			return nombre;
		}
		
		public int getDni(){
			return dni;
		}
		
		public bool sosIgual(IComparable a){
			Persona otraPersona= (Persona)a;
			return this.dni == otraPersona.getDni();
		}
		
		public bool sosMenor(IComparable a){
			Persona otraPersona=(Persona)a;
			return this.dni < otraPersona.getDni();
		}
		
		public bool sosMayor(IComparable a){
			Persona otraPersona=(Persona)a;
			return this.dni > otraPersona.getDni();
		}
	}
}
