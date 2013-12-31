using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.interval
{
	/// <summary>
	/// for an IComparable, benchmarker is the operation composited.
	/// </summary>
	public partial interface OrderI<T>
		where T:IComparable<T>
	{
		bool contains(T item1,T item2);

	}
}
