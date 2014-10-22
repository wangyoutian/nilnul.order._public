using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.extended
{
	public partial class Interval<T,TComparerSingleton>
		:nilnul.order.extended.Interval<T>
		where TComparerSingleton:IComparer<T>,new()
	{
		public Interval(
			nilnul.order.Bound<T> lower
			,
			nilnul.order.Bound<T> upper

			
		)
			:this(
				new Cut<T>(lower)
				,
				new Cut<T>(upper)
			)


		{

		}

		public Interval(
			nilnul.order.cut.Cut<T> lower
			,
			nilnul.order.cut.Cut<T> upper
		)
			:this(new nilnul.order.Bound<T>(lower),new nilnul.order.Bound<T>(upper))

		{

		}

		public Interval(Cut<T> lower,Cut<T> upper)
			:base(
			
			lower,upper
			
			,Comparer<T,TComparerSingleton>.Singleton)
		{

		}


	}
}
