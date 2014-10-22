using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut.interval.rel
{
	public partial class Eq
	{

		static public bool Eval<T>(
			Pair<T> a
			,
			Pair<T> b
			,
			IComparer<T> c


		)
		{

			return Eval(a, b, new Comparer<T>(c));



		}
		static public bool Eval<T>(
			Pair<T> a
			,
			Pair<T> b
			,
			IComparer<Cut<T>> c


		)
		{


			return c.Compare(a.lower, b.lower) == 0 && c.Compare(a.upper, b.upper) == 0;




		}
	}
}
