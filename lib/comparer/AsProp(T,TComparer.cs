using nilnul.order.total;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class AsProp<T,TComparer>
		:
		AsProp<T>
		where TComparer:total.ComparerI3<T>,new()
	{
		public AsProp()
			:base(SingletonByDefault<TComparer>.Instance)
		{

		}
	}
}
