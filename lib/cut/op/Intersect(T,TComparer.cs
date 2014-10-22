using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut.op
{
	public partial class Intersect<T,TComparer>
		where TComparer:IComparer<T>,new()
	{


		static public TComparer Comparer = SingletonByDefault<TComparer>.Instance;

		static public Interval<T, TComparer> Eval(Interval<T,TComparer> a,Interval<T,TComparer> b) {


			return new Interval<T, TComparer>(
				Intersect<T>.Eval_lowerBound( a.lower ,b.lower,Comparer)
				,
				Intersect<T>.Eval_upperBound( a.lower ,b.lower,Comparer)
				
			);
			throw new NotImplementedException();
		}

		static public Interval<T, TComparer> Eval(
			IEnumerable<Interval<T,TComparer>> intervals
			
		) {

			if (intervals.Count()==0)
			{
				return Interval<T, TComparer>.CreateAll();
				
			}

			return Eval(intervals.First(), Eval(intervals.Skip(1)));

			throw new NotImplementedException();
		
		
		}

		
		static public LowerBound<T,TComparer> Eval(LowerBound<T, TComparer> a, LowerBound<T, TComparer> b)
		{
			if (a==null)
			{
				return LowerBound<T,TComparer>.Create( b);
				
			}
			if (b==null)
			{
				return LowerBound<T,TComparer>.Create( a);
				
			}
			if (
				Comparer.Compare(a.pinpoint, b.pinpoint) == 0

			)
			{
				if (a.openFalseCloseTrue && b.openFalseCloseTrue)
				{
					return new LowerBoundClose<T, TComparer>(a.pinpoint);

				}
				return new LowerBoundOpen<T, TComparer>(a.pinpoint);

			}
			if (Comparer.Compare(a.pinpoint, b.pinpoint) < 0)
			{
				if (b.openFalseCloseTrue)
				{
					return new LowerBoundClose<T, TComparer>(b.pinpoint);

				}
				return new LowerBoundOpen<T, TComparer>(b.pinpoint);

			}
			if (a.openFalseCloseTrue)
			{
				return new LowerBoundClose<T, TComparer>(a.pinpoint);

			}
			return new LowerBoundOpen<T, TComparer>(a.pinpoint);


			throw new NotImplementedException();

		}

		static public LowerBound<T,TComparer> Eval(IEnumerable<LowerBound<T, TComparer>> a)
		{
			if (a.Count()==0)
			{
				return null;
			}
			//if (a.Count()==1)
			//{
			//	return a.First();
				
			//}
			return Eval(
				a.First(),
				Eval( a.Skip(1))
			);

			throw new NotImplementedException();

		}

		static public UpperBound<T,TComparer> Eval(UpperBound<T, TComparer> a, UpperBound<T, TComparer> b)
		{
			if (a==null)
			{
				return UpperBound<T, TComparer>.Create(b);
				
			}
			if (b==null)
			{
				return UpperBound<T, TComparer>.Create(a);
				
			}
			if (
				Comparer.Compare(a.pinpoint, b.pinpoint) == 0

			)
			{
				if (a.openFalseCloseTrue && b.openFalseCloseTrue)
				{
					return new UpperBoundClose<T, TComparer>(a.pinpoint);

				}
				return new UpperBoundOpen<T, TComparer>(a.pinpoint);

			}
			if (Comparer.Compare(a.pinpoint, b.pinpoint) < 0)
			{
				if (b.openFalseCloseTrue)
				{
					return new UpperBoundClose<T, TComparer>(a.pinpoint);

				}
				return new UpperBoundOpen<T, TComparer>(a.pinpoint);

			}
			if (a.openFalseCloseTrue)
			{
				return new UpperBoundClose<T, TComparer>(b.pinpoint);

			}
			return new UpperBoundOpen<T, TComparer>(b.pinpoint);


			throw new NotImplementedException();

		}


		static public UpperBound<T, TComparer> Eval(
		
	
			IEnumerable<UpperBound<T,TComparer>> upperBounds
		) {

			if (upperBounds.Count()==0)
			{
				return null;
				
			}
			return Eval(upperBounds.First(),Eval( upperBounds.Skip(1)));


		
			throw new NotImplementedException();
		
		}


	}
}
