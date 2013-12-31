using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.relation.order;

namespace nilnul.order
{
	/// <summary>
	/// IComparable is treated linears.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// Definition: Within a set, Any two different elements a,b. either a>b, or b>a.
	/// 
	/// Corrolary:
	/// 1) It's diffrent with total order in that, 
	/// <ol>
	/// <li>
	/// {a, b } is undefined if a==b. while total order gurantees any two elements are comparable.
	/// </li>
	/// <li>
	/// for {a , b}, either (a,b) or (b,a) is defined, but not both.
	/// </li>
	/// </ol>
	/// 
	/// 
	/// This is antisymmetric, asymmetric, 
	/// 
	/// for two same elements, it's undefined. As a set of pairs: it can or doesn't contain a pair of two same elements.
	/// 
	/// 
	/// 
	/// </remarks>
	

	public interface LinearI : OrderI
	{
	}

	
}
