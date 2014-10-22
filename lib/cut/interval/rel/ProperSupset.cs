using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut.interval.rel
{
	public partial class ProperSupset
	{
		static public bool Eval<T>(
			Pair<T> a
			,
			Pair<T> b
			,
			IComparer<T> c
			
		) {

			return Supset.Eval(a, b, c) && Neq.Eval(a, b, c);


			throw new NotImplementedException();
		}
		static public bool Eval<T>(
			Pair<T> a
			,
			Pair<T> b
			,
			IComparer<Cut<T>> c
			
		) {

			return Supset.Eval(a, b, c) && Neq.Eval(a, b, c);


			throw new NotImplementedException();
		}
	}
}
