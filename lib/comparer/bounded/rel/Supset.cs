using nilnul.order.bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer.bounded.rel
{
	public partial class Supset
	{

		static public bool Eval<T>(
			Pair<T> a
			,
			Pair<T> b
			,
			IComparer<T> c

		)
		{

			return new LowerComparer<T>(c).Compare(a.lower, b.lower) <= 0 && new UpperComparer<T>(c).Compare(a.upper, b.upper) >= 0;


			throw new NotImplementedException();
		}

		static public bool Eval<T,TBound>(
	Pair_TBound<TBound> a
	,
	Pair_TBound<TBound> b
	,
	IComparer<T> c

)
			where TBound:Bound<T>
		{

			return new LowerComparer<T>(c).Compare(a.lower, b.lower) <= 0 && new UpperComparer<T>(c).Compare(a.upper, b.upper) >= 0;


			throw new NotImplementedException();
		}

	}
}
