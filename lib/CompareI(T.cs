using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial interface CompareI<T>
	{
		Sign compare(T a, T b);
	}
}
