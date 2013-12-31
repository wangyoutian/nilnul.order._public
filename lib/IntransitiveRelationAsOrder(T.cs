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
	public partial class IntransitiveRelationAsOrder<T>
		//:
		//Relation<T>
		//,
		//OrderI<T>

		where T:IEquatable<T>
	{

		static public HashSet<T> _Maximal<T>(
			IEnumerable<nilnul.relation.Pair<T>> nodes
			
		) 
		where T:IEquatable<T>
		{


			var r = RelationX.Range(nodes);

			var domain = RelationX.Domain(nodes);

			r.ExceptWith(domain);
			return r;




		}

		static public HashSet<T> _Minimal<T>(
		IEnumerable<nilnul.relation.Pair<T>> nodes

	)
	where T : IEquatable<T>
		{

			return _Maximal(nodes.Select(c=>c.inverse()));

		}




	}
}
