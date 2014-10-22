using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.extended.cut
{
	public partial class Pair<T>
		:  nilnul.order.cut.Pair<ExtendedTypeI2<T>,Cut<T>>

	{

		public Pair(Cut<T> lower,Cut<T> upper)
			:base(lower,upper)
		{


		}


		

	}
}
