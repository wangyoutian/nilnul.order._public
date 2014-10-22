using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.comparer.interval
{
	/// <summary>
	/// restricted back to an interval of elements of the type that is not extended.
	/// </summary>
	public partial class Restricted<T>
		:nilnul.bit.Be<Interval<T>>
	{
		static public bool Be(Interval<T> interval) {

			return Cut<T>.Not_CloseAndInfOrNegInf(interval.lower) && Cut<T>.Not_CloseAndInfOrNegInf(interval.upper);
		
		
		}

		public Restricted()
			:base(Be)
		{

		}

		public class Expr
			:nilnul.bit.be.Asserted<Interval<T>,Restricted<T>>
			,
			nilnul.collection.ContainsI<T>


		{
			public Expr(Interval<T> interval)
				:base(interval)
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
