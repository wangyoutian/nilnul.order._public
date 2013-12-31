using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// In mathematics, a well-order relation (or well-ordering) on a set S is a total order on S with the property that every non-empty subset of S has a least element in this ordering.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface WellOrderedSetI<T>
		where T:IComparable<T>
	{

		T minimum();


	}
}
