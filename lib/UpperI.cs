using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial interface UpperI<T> : TotalI<T>
		where T:IComparable<T>
		//,
		//IEquatable<T>
	{

	}

	
}
