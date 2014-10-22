using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.comparer.interval
{
	/// <summary>
	/// restricted back to an interval of elements of the type that is not extended.
	/// </summary>
	public partial class Restricted<T,TComparer>
		:nilnul.bit.Be<Interval<T,TComparer>>
		where TComparer:IComparer<T>,new()
	{
		static public bool Be(Interval<T,TComparer> interval) {

			return Cut<T>.Not_CloseAndInfOrNegInf(interval.lower) && Cut<T>.Not_CloseAndInfOrNegInf(interval.upper);
		
		
		}

		public Restricted()
			:base(Be)
		{

		}

		public class Expr
			:nilnul.bit.be.Asserted<Interval<T,TComparer>,Restricted<T>>
			,
			nilnul.collection.ContainsI<T>


		{
			public Expr(Interval<T,TComparer> interval)
				:base(interval)
			{

			}

			public Expr(nilnul.order.cut.Cut<T> lower, nilnul.order.cut.Cut<T> upper)
				:this(
					new nilnul.order.ext.comparer.Interval<T,TComparer>(lower,upper)
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
