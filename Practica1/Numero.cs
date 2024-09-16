/*
 * Created by SharpDevelop.
 * User: User
 * Date: 05/09/2024
 * Time: 16:20
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Practica1
{
	/// <summary>
	/// Description of Numero.
	/// </summary>
	public class Numero : IComparable
	{
		private List<IComparable> elementos;
		private int valor;
		
		public Numero(int valor)
		{
			this.valor=valor;
		}
		
		public int getValor(){
			return valor;
		}
		
		
		
		public bool sosIgual(IComparable a){
			Numero otroNuemero= (Numero)a;
			return this.valor == otroNuemero.getValor();
		}
		
		public bool sosMenor(IComparable a){
			Numero otroNuemero= (Numero)a;
			return this.valor < otroNuemero.getValor();
		}
		
		public bool sosMayor(IComparable a){
			Numero otroNuemero= (Numero)a;
			return this.valor > otroNuemero.getValor();
		}
		
		
		public void agregar(IComparable a){
			elementos.Add(a);
			
		}
		
		public int Cuantos(){
			return elementos.Count;
		}
		
		public IComparable minimo(){
			IComparable minimo= elementos[0];
			foreach (var element in elementos) {
				if (element.sosMenor(minimo)) {
					minimo= element;
				}
			}
			
			return minimo;
			
			
		}
		
		public IComparable maximo(){
			IComparable maximo= elementos[0];
			foreach (var elemento in elementos) {
				if (elemento.sosMayor(maximo)) {
					maximo= elemento;
				}
			}
			
			return maximo;
		}
		
		public bool contiene(IComparable a){
			foreach (var elemento in elementos) {
				if (elemento.sosIgual(a)) {
					return true;
				}
			
				
			}
			
		   return false;
			
		}
		
	
		
		
	}
}
