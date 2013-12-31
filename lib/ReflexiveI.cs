using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public interface ReflexiveI<T> : OrderI<T>
		where T:IComparable<T>
		//,IEquatable<T>
	{
	}
}
