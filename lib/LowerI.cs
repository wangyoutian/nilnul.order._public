using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// lower set.
	/// </summary>
	public partial interface LowerI<T>:TotalI<T>
		where T:IComparable<T>
	{

	}
}
