using System;
namespace nilnul.order
{
	public partial interface EqualityI<T>
		:nilnul.order.OrderI<T>
		,
		nilnul.relation.EquivalentRelationI<T>
	{
		
	}
}
