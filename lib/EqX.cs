using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  nilnul.order
{
	

	static public partial class EqX {
		static public bool Eq<T>(this T x,T y)
			where T:IComparable<T>
			{
				return x.CompareTo(y) == 0;
		
			}
	
	}

	
}
