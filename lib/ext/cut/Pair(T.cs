using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.cut
{
	public partial class Pair<T>
		:  nilnul.order.cut.Pair1<ExtendedI<T>,Cut<T>>

	{

		public Pair(Cut<T> lower,Cut<T> upper)
			:base(lower,upper)
		{


		}


		

	}
}
