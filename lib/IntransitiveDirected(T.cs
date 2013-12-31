using nilnul.relation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// intransitive(n) when n!=1.
	/// 
	/// </summary>
	/// <remarks>
	/// finite,
	/// literal,
	/// directed,
	/// acyclic, so irreflexive
	
	/// </remarks>
	public partial class IntransitiveDirected<T>
		:
		OrderI<T>

		//where T:IEquatable<T>
	{
		public Relation<T> _relation;


		public bool contains(T first, T second)
		{
			throw new NotImplementedException();
		}


		
	}
}
