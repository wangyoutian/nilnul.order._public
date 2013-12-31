using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// there are maximals and minmals.
	/// </summary>
	public partial interface BoundedOrderI<T>
		:
		LowerBoundedOrderI
		,
		UpperBoundedI
	{

	}
}
