using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial interface CutAsUpperI<T,TCut>
	{
		TCut upper { get; }


	}
}
