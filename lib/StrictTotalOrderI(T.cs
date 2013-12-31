using System;
namespace nilnul.order
{
	public partial interface StrictTotalOrderI<in T>
		:
		StrictOrderI<T>,


		nilnul.relation.IrreflexiveRelationI<T>,

		OrderI<T>
		
	{
		

		
	}
}
