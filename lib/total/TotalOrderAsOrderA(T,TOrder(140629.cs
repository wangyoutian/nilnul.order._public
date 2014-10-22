using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public abstract partial class TotalOrderAsOrderA<T,TOrder>
		:TotalOrderAsOrderA<T>

		where TOrder:total.OrderI<T>,new()
	{
		public TotalOrderAsOrderA()
			:base(SingletonByDefaultNew<TOrder>.Instance)
		{
			

		}

	
	}
}
