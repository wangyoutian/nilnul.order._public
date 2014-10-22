using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial interface CutAsUpperI1<T,TCut>
		where TCut:order.Bound<T>
	{
		TCut upper { get; }


	}
}
