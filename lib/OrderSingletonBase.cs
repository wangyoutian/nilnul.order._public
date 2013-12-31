using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class OrderSingletonBase<OrderSingleton,T>
		//where OrderSingleton:OrderI<T>
		
	{
		protected static  OrderSingleton _order;
		public static OrderSingleton order {
			get {
				return _order;
			}
		}
		




	}
}
