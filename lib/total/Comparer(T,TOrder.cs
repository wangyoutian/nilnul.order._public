using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public partial class Comparer<T,TOrder>
		:Comparer<T>
		where TOrder:OrderI<T>,new()
	{
		public Comparer()
			:base(SingletonByDefault<TOrder>.Instance)
		{

		}
	}
}
