using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace  nilnul.order
{
	

	static public partial class GeX
	{
		static public bool Ge<T>(this T x, T y)
			where T : IComparable<T>
		{
			return x.Eq(y) || x.Gt(y);
		}
		
	}
}
