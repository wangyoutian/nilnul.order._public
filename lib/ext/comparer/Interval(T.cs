using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.comparer
{
	public partial class Interval<T>
		:nilnul.order.comparer.Interval<ExtendedI<T>>
	{

		public Interval(Cut<T> lower,Cut<T> upper,Comparer<T> comparer)
			:base(lower,upper,comparer)
		{

		}


	}
}
