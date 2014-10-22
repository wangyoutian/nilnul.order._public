using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.op
{
	public partial class Intersect<T,TComparer>
		where TComparer:IComparer<T>,new()
	{

		static public TComparer Comparer = SingletonByDefault<TComparer>.Instance;


		static public IntervalI1<T> Eval(
			IntervalI<T,TComparer> a
			,
			IntervalI<T,TComparer> b

			
		) {





			throw new NotImplementedException();
		
		}

		static public Interval_froCut<T, TComparer> Eval(
			Interval_froCut<T,TComparer> x
			,
			Interval_froCut<T,TComparer> y
			
		) {

			return new Interval_froCut<T, TComparer>(
				order.cut.LowerBoundComparer<T,TComparer>.Max(x.lower,y.lower)
				,

				order.cut.UpperBoundComparer<T,TComparer>.Min(x.upper,y.upper)
	
			);

			throw new NotImplementedException();
		}

		static public All<T, TComparer> Eval(All<T,TComparer> a,All<T,TComparer> b) {
			return new All<T, TComparer>();
		}

		static public IntervalI1<T> Eval(
			All<T, TComparer> a
			,
			IntervalI<T, TComparer> b
		)
		{

			return b;
		}
		static public IntervalI1<T> Eval(
			IntervalI<T, TComparer> b
			,
			All<T, TComparer> a
		)
		{

			return b;
		}



		static public IntervalI1<T> Eval(
			LowerBoundUpperNullI<T, TComparer> b
			,


			LowerBoundUpperNullI<T, TComparer> a
		)
		{
			if (
				Comparer.Compare(a.lowerBound,b.lowerBound) ==0
			)
			{
				if (a is LowerBoundCloseI && b is LowerBoundCloseI)
				{
					return new LowerCloseUpperNull<T, TComparer>(a.lowerBound);

				}
				else
				{
					return new LowerOpenUpperNull<T, TComparer>(a.lowerBound);
				}

			}
			else
			{
				if (
					Comparer.Compare(a.lowerBound,b.lowerBound)>0	
				)
				{
					if (a is LowerBoundCloseI)
					{
						return new LowerCloseUpperNull<T, TComparer>(a.lowerBound);
					}

					return new LowerOpenUpperNull<T, TComparer>(a.lowerBound);


				}
				else
				{
					if ( b is LowerBoundCloseI)
					{
						return new LowerCloseUpperNull<T, TComparer>(b.lowerBound);
						
					}
					return new LowerOpenUpperNull<T, TComparer>(b.lowerBound);
				}
			}

		}


		static public IntervalI1<T> Eval(
			LowerNullUpperBoundI<T,TComparer> a
			,

			LowerNullUpperBoundI<T,TComparer> b

		)
		{
			if (
				Comparer.Compare(a.upperBound, b.upperBound) == 0
			)
			{
				if (a is UpperBoundCloseI && b is UpperBoundCloseI)
				{
					return new LowerNullUpperClose<T, TComparer>(a.upperBound);

				}
				else
				{
					return new LowerNullUpperOpen<T, TComparer>(a.upperBound);
				}

			}
			else
			{
				if (
					Comparer.Compare(a.upperBound, b.upperBound) > 0
				)
				{
					if (b is UpperBoundCloseI)
					{
						return new LowerNullUpperClose<T, TComparer>(b.upperBound);
					}

					return new LowerNullUpperOpen<T, TComparer>(b.upperBound);


				}
				else
				{
					if (a is UpperBoundCloseI)
					{
						return new LowerNullUpperClose<T, TComparer>(a.upperBound);

					}
					return new LowerNullUpperOpen<T, TComparer>(a.upperBound);
				}
			}

		}



		static public IntervalI1<T> Eval(
			LowerBoundUpperNullI<T, TComparer> a
			,
			LowerNullUpperBoundI<T, TComparer> b


		)
		{
			if (a is LowerBoundCloseI)
			{
				if (b is UpperBoundCloseI)
				{
					return new bounded.Close<T, TComparer>(a.lowerBound, b.upperBound);
				}
				return new bounded.Clopen<T, TComparer>(a.lowerBound, b.upperBound);
				
			}
			if (b is UpperBoundCloseI)
			{
				return new bounded.OpenClose<T, TComparer>(a.lowerBound, b.upperBound);
				
			}
			return new bounded.Open<T, TComparer>(a.lowerBound, b.upperBound);


			throw new NotImplementedException();

		}




		static public IntervalI1<T> Eval(
			LowerBoundUpperNullI<T, TComparer> a
			,
			BoundedA_TSysComparer<T, TComparer> b


		)
		{

			if (a is LowerBoundCloseI)
			{
				if (b is UpperBoundCloseI)
				{
					return new bounded.Close<T, TComparer>(a.lowerBound, b.upperBound);
				}
				return new bounded.Clopen<T, TComparer>(a.lowerBound, b.upperBound);

			}
			if (b is UpperBoundCloseI)
			{
				return new bounded.OpenClose<T, TComparer>(a.lowerBound, b.upperBound);

			}
			return new bounded.Open<T, TComparer>(a.lowerBound, b.upperBound);


			throw new NotImplementedException();

		}






		


	}
}
