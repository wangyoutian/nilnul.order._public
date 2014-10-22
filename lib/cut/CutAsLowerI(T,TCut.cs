using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial interface CutAsLowerI<T,TCut>
		where TCut:Cut<T>
	{
		TCut lower { get; }


	}
}
