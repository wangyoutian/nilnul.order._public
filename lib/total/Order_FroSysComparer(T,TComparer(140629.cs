using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public partial class Order_FroSysComparer<T,TComparer>
		:
		Order_FroSysComparer<T>

		where TComparer:IComparer<T>,new()
		
	{
		public Order_FroSysComparer()
			:base(SingletonByDefault<TComparer>.Instance as IComparer<T>)
		{

		}
	}
}
