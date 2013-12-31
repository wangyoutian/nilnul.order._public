using System;
namespace nilnul.order.total.bound
{
	/// <summary>
	/// a total bound order.
	/// </summary>
	/// <typeparam name="T">
	/// </typeparam>
	public partial interface OrderI<T>
		:
		nilnul.order.total.OrderI<T>
		,
		nilnul.order.total.BoundedI<T>
		
	{

		
		

		
	}
}
