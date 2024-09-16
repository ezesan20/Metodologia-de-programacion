/*
 * Created by SharpDevelop.
 * User: User
 * Date: 05/09/2024
 * Time: 16:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica1
{
	/// <summary>
	/// Description of IComparable.
	/// </summary>
	public interface IComparable
	{
		bool sosIgual(IComparable a);
		bool sosMenor(IComparable a);
		bool sosMayor(IComparable a);
		
	}
}
