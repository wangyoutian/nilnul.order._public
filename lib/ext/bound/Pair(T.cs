using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.bound
{
	public partial class Pair<T>
		:  nilnul.order.bound.Pair<ExtendedI<T>,Bound<T>>

	{

		public Pair(Bound<T> lower,Bound<T> upper)
			:base(lower,upper)
		{


		}


		

	}
}
