/*
 * Created by SharpDevelop.
 * User: User
 * Date: 12/09/2024
 * Time: 20:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace Practica1
{
	/// <summary>
	/// Description of ColeccionMultiple.
	/// </summary>
	public class ColeccionMultiple:Coleccionable
	{
		private Pila pilab;
		private Cola colab;
		
		public ColeccionMultiple(Pila pilab,Cola colab)
		{
			this.pilab=pilab;
			this.colab=colab;
		}
		
     
		public IComparable maximo(){
			if (pilab.maximo().sosMayor(colab.maximo())) {
				return pilab.maximo();
				}
			else{
					return colab.maximo();
				}
		}
		
		
		
		public IComparable minimo(){
			if (pilab.minimo().sosMenor(colab.minimo())) {
				return pilab.minimo();
			}
			else{
				return colab.minimo();
			}
		}
		public void agregar(IComparable a){}
		public bool contiene(IComparable a){
			if (pilab.contiene(a) && colab.contiene(a)) {
				return true;
			}
			
			return false;
			
		}
		public int Cuantos(){
			return pilab.Cuantos() + colab.Cuantos();
		}
		
		
	}
}
