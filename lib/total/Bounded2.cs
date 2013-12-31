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
	public partial interface BoundedI2<T>
		
	{
		T maximum { get; }
		T minimum { get; }
	}
}
