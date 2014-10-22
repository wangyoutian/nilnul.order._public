using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.comparer
{
	public partial class Bounded<T,TComparer>
		:Bounded<T>
		where TComparer:IComparer<T>,new()
	{
		public Bounded(Bound<T> a,Bound<T> b)
			:base(a,b,new Comparer<T,TComparer>())
		{

		}

		public Bounded(order.Bound<ExtendedI<T>> a, order.Bound<ExtendedI<T>> b)
			:this(
				new Bound<T>(a)
			,
				new Bound<T>(b)
			)
		{

		}

		public Bounded(
			nilnul.order.comparer.Bounded<ExtendedI<T>> x	
		)
			:this(x.lower,x.upper)
		{

		}

	}
}
