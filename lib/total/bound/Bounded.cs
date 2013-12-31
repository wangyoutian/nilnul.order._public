using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total.bound
{
	/// <summary>
	/// bounded total order
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface BoundedI<T>
		
	{
		T maximum { get; }
		T minimum { get; }
	}
}
