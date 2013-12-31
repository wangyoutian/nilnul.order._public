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
	static public partial class IntransitiveDirectedX
	{


		static public T _MaximalOrDefault<T>(
			IEnumerable<nilnul.relation.Pair<T>> arcs

		)
		{


			return IntransitiveX._Maximal(arcs).FirstOrDefault();




		}

		static public T _Maximal<T>(
			IEnumerable<nilnul.relation.Pair<T>> arcs

		)
		
		{

			
			return IntransitiveX._Maximal(arcs).FirstOrDefault();




		}

		static public T _Maximal<T>(
	IEnumerable<nilnul.relation.Pair2<T>> arcs

)
		{


			return IntransitiveX._Maximal(arcs).FirstOrDefault();




		}




		static public T _Minimal<T>(
			IEnumerable<nilnul.relation.Pair<T>> arcs

		)
		{

			return _Maximal(arcs.Select(c => c.inverse()));

		}

		static public T _Minimal<T>(
	IEnumerable<nilnul.relation.Pair2<T>> arcs

)
		{

			return _Maximal(arcs.Select(c => c.toInverse()));

		}





	}
}
