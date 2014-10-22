using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.bound
{
	public partial class Pair<T>
		:Pair_TBound<Bound<T>>

		
	{
		

		public Pair(Bound<T> lower,Bound<T> upper)
			:base(lower,upper)
		{

		}

		
	}
}
