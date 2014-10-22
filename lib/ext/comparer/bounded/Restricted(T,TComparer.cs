using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.comparer.bounded
{
	/// <summary>
	/// restricted back to an interval of elements of the type that is not extended.
	/// </summary>
	public partial class Restricted<T,TComparer>
		:nilnul.bit.Be<Bounded<T,TComparer>>
		where TComparer:IComparer<T>,new()
	{
		static public bool Be(Bounded<T, TComparer> interval)
		{

			return Bound<T>.Not_CloseAndInf(interval.lower) && Bound<T>.Not_CloseAndInf(interval.upper);


		}
		static public bool Be<TBound>(Bounded<T, TComparer, TBound> interval)
			where TBound : Bound<T>
		{

			return Bound<T>.Not_CloseAndInf(interval.lower) && Bound<T>.Not_CloseAndInf(interval.upper);


		}

		static public bool Be<TBound>(nilnul.order.bound.Pair<ExtendedI<T>, TBound> interval)
			where TBound : Bound<T>
		{

			return Bound<T>.Not_CloseAndInf(interval.lower) && Bound<T>.Not_CloseAndInf(interval.upper);


		}

		public Restricted()
			:base(Be)
		{

		}

		public class Expr
			:nilnul.bit.be.Asserted<Bounded<T,TComparer>,Restricted<T>>
			,
			nilnul.collection.ContainsI<T>


		{
			public Expr(Bounded<T,TComparer> interval)
				:base(interval)
			{

			}

			public Expr(nilnul.order.ext.Bound<T> lower, nilnul.order.ext.Bound<T> upper)
				:this(
					new nilnul.order.ext.comparer.Bounded<T,TComparer>(lower,upper)
				)
			{
				
			}


			public bool contains(T item)
			{
				return val.contains( new Literal<T>(  item));
				throw new NotImplementedException();
			}


		}

		



	}
}
