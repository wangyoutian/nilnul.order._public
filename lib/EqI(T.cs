using System;
namespace nilnul.order
{
	public partial interface EqI<T>
		:nilnul.order.OrderI<T>
		,
		nilnul.relation.EquivalentRelationI<T>
	{
		
	}
}
