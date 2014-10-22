using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.comparer.bounded
{
	/// <summary>
	/// restricted back to an interval of elements of the type that is not extended.
	/// </summary>
	public partial class Restricted<T>
		:nilnul.bit.Be<Bounded<T>>
	{
		static public bool Be(Bounded<T> interval) {

			return Bound<T>.Not_CloseAndInf(interval.lower) && Bound<T>.Not_CloseAndInf(interval.upper);
		
		
		}

		public Restricted()
			:base(Be)
		{

		}

		public class Expr
			:nilnul.bit.be.Asserted<Bounded<T>,Restricted<T>>
			,
			nilnul.collection.ContainsI<T>


		{
			public Expr(Bounded<T> interval)
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
