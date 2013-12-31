using System;
namespace nilnul.order
{
	public partial interface TotalOrderI2<in T>
		:
		OrderI<T>
		
	{
		Sign compare(T x, T y);
		

		
	}
}
