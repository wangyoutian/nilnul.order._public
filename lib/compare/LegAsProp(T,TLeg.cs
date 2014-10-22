using nilnul.order.total;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.compare
{
	public partial class LegAsProp<T,TLeg>
		:
		LegAsProp<T>

		where TLeg:LegI<T>,new()
	{
		public LegAsProp()
			:base(SingletonByDefaultNew<TLeg>.Instance)
		{

		}
	}
}
