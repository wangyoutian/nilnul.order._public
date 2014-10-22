using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial interface CutAsLowerI1<T,TCut>
		where TCut:order.Bound<T>
	{
		TCut lower { get; }


	}
}
