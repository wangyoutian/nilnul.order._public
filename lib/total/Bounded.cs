using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	/// <summary>
	/// bounded total order
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface BoundedI<T>
		:TotalOrderI3<T>
		,
		BoundedOrderI
	{
		T maximum { get; }
		T minimum { get; }
	}
}
