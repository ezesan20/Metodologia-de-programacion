/*
 * Created by SharpDevelop.
 * User: User
 * Date: 13/09/2024
 * Time: 17:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica1
{
	/// <summary>
	/// Description of Alumno.
	/// </summary>
	public class Alumno:Persona,IComparable
	{
		private int legajo;
		private double promedio;
		
		public Alumno(string nombre, int dni, int legajo, double promedio ):base(nombre,dni)
		{
			this.legajo=legajo;
			this.promedio=promedio;
		}
		
		public int getLegajo(){
			return legajo;
		}
		
		public double getpromedio(){
			return promedio;
		}
		
		public bool sosIgual(IComparable a){
			Alumno otraPersona= (Alumno)a;
			return this.legajo == otraPersona.getLegajo();
		}
		
		public bool sosMenor(IComparable a){
			Alumno otraPersona=(Alumno)a;
			return this.legajo < otraPersona.getLegajo();
		}
		
		public bool sosMayor(IComparable a){
			Alumno otraPersona=(Alumno)a;
			return this.legajo > otraPersona.getLegajo();
		}
	}
}
