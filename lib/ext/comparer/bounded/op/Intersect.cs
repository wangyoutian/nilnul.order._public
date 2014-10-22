using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.comparer.bounded.op
{
	public partial class Intersect<T,TComparer>

		:nilnul.order.comparer.bounded.op.Intersect<
			ExtendedI<T>,ext.Comparer<T,TComparer>
		>
		,
		nilnul.obj.op.binary.ClosedI<Bounded<T,TComparer>>

		where TComparer:IComparer<T>,new()
	{

		static public Bounded<T,TComparer> Eval(Bounded<T,TComparer> x, Bounded<T,TComparer> y) {
 
			return new Bounded<T,TComparer>(
				nilnul.order.comparer.bounded.op.Intersect<ExtendedI<T>,Comparer<T,TComparer>>.Eval(
				
					new order.comparer.Bounded<ExtendedI<T>,Comparer<T,TComparer>>( x.lower,x.upper)
					,

					new order.comparer.Bounded<ExtendedI<T>,Comparer<T,TComparer>>(y.lower,y.upper)
				
				)
				
				
			);

		
		}






		public Bounded<T, TComparer> eval(Bounded<T, TComparer> a, Bounded<T, TComparer> b)
		{


			return new Bounded<T,TComparer>(
				nilnul.order.comparer.bounded.op.Intersect<ExtendedI<T>,Comparer<T,TComparer>>.Eval(
				
					new order.comparer.Bounded<ExtendedI<T>,Comparer<T,TComparer>>( a.lower,a.upper)
					,

					new order.comparer.Bounded<ExtendedI<T>,Comparer<T,TComparer>>(b.lower,b.upper)
				
				)
				
				
			);
			throw new NotImplementedException();
		}


		public Bounded<T, TComparer> eval<TBound>
			(Bounded<T, TComparer, TBound> a, Bounded<T, TComparer, TBound> b)

			where TBound : Bound<T>
		{


			return new Bounded<T, TComparer>(
				nilnul.order.comparer.bounded.op.Intersect<ExtendedI<T>, Comparer<T, TComparer>>.Eval(

					new order.comparer.Bounded<ExtendedI<T>, Comparer<T, TComparer>>(a.lower, a.upper)
					,

					new order.comparer.Bounded<ExtendedI<T>, Comparer<T, TComparer>>(b.lower, b.upper)

				)


			);
			throw new NotImplementedException();
		}
		static public Bounded<T, TComparer> Eval<TBound>
			(Bounded<T, TComparer, TBound> a, Bounded<T, TComparer, TBound> b)

			where TBound : Bound<T>
		{


			return new Bounded<T, TComparer>(
				nilnul.order.comparer.bounded.op.Intersect<ExtendedI<T>, Comparer<T, TComparer>>.Eval(

					new order.comparer.Bounded<ExtendedI<T>, Comparer<T, TComparer>>(a.lower, a.upper)
					,

					new order.comparer.Bounded<ExtendedI<T>, Comparer<T, TComparer>>(b.lower, b.upper)

				)


			);
			throw new NotImplementedException();
		}

	}
}
