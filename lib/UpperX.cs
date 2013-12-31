using nilnul.relation.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	static public partial class UpperX
	{
		static public void AssertUpper<T>(OrderI<T> order)
		where T:IComparable<T>,IEquatable<T>
		{
			if (! (order is UpperI<T>))
			{
				throw new Exception();
				
			}
		
		}
	}
}
