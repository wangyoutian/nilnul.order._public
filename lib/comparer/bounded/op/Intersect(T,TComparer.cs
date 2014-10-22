using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer.bounded.op
{
	public partial class Intersect<T,TComparer>
		where TComparer:IComparer<T>,new()
	{


		static public Bounded<T, TComparer> Eval(Bounded<T, TComparer> a, Bounded<T, TComparer> b)
		{
			return new Bounded<T, TComparer>(
				bound.LowerComparer<T>.Max(a.lower, b.lower, SingletonByDefault<TComparer>.Instance)
				,
				bound.UpperComparer<T>.Min(a.upper, b.upper, SingletonByDefault<TComparer>.Instance)

			);
		}
		static public Bounded<T, TComparer> Eval<TBound>(Bounded<T, TComparer,TBound> a, Bounded<T, TComparer,TBound> b)

			where TBound:Bound<T>
		{
			return new Bounded<T, TComparer>(
				bound.LowerComparer<T>.Max(a.lower, b.lower, SingletonByDefault<TComparer>.Instance)
				,
				bound.UpperComparer<T>.Min(a.upper, b.upper, SingletonByDefault<TComparer>.Instance)

			);
		}
	}
}
