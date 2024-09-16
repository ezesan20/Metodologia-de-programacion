/*
 * Created by SharpDevelop.
 * User: User
 * Date: 12/09/2024
 * Time: 18:21
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Practica1
{
	/// <summary>
	/// Description of Cola.
	/// </summary>
	public class Cola: Coleccionable
	{
		private List<IComparable> elementos;
		
		public Cola()
		{
			elementos=new List<IComparable>();
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
