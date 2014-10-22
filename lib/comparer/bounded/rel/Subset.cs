using nilnul.order.bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer.bounded.rel
{
	public partial class Subset
	{
		static public bool Eval<T>(
			Pair<T> a
			,
			Pair<T> b
			,
			IComparer<T> c
			
		) {
			return Supset.Eval(b, a, c);


			throw new NotImplementedException();
		}
	
	}
}
