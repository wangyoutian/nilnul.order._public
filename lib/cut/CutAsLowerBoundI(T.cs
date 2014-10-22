using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial interface CutAsLowerBoundI<T>
	{
		Cut<T> lower { get; }


	}
}
