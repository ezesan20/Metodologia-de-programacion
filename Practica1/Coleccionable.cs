
/*
 * Created by SharpDevelop.
 * User: User
 * Date: 05/09/2024
 * Time: 19:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica1
{
	/// <summary>
	/// Description of Coleccionable.
	/// </summary>
	public interface Coleccionable
	{
		int Cuantos();
		IComparable minimo();
		IComparable maximo();
		void agregar(IComparable a);
		bool contiene(IComparable a);
		
		
		
	}
}
