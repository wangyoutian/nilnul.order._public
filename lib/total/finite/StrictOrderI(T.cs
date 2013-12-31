using System;
namespace nilnul.order.total.finite
{
	public partial interface StrictOrderI<T>
		:
		nilnul.order.total.StrictOrderI<T>
		,
		nilnul.order.total.BoundedI<T>,

		nilnul.relation.RelationI2<T>
	{
		

		
	}
}
