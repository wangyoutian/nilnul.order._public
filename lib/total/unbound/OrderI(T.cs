using System;
namespace nilnul.order.total.unbound
{
	public partial interface OrderI<in T>
		:
		nilnul.order.unbound.OrderI<T>
		,
		nilnul.order.total.OrderI<T>
		
	{
		
		

		
	}
}
