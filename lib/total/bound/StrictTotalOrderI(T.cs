using System;
namespace nilnul.order.total.bound
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface StrictOrderI< T>
		:
		nilnul.order.total.StrictOrderI<T>
		
	{
		T maximum { get; }
		T minimum { get; }
		

		
	}
}
