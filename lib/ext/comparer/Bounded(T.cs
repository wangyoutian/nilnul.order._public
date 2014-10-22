using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.comparer
{
	public partial class Bounded<T>
		:
		nilnul.order.comparer.Bounded<ExtendedI<T>>
	{
		public Bounded(
			Bound<T> lower
			,
			Bound<T> upper
			,
			Comparer<T> comparer
		)
		:base(
			lower
			,
			upper
			,
			comparer
		)
		{

		}
	}
}
