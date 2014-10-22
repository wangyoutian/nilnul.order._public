using nilnul.order.total;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class AsProp_SysComparer<T,TComparer>
		:
		AsProp<T, total.Comparer_SysComparer<T,TComparer>>
		where TComparer:IComparer<T>,new()
	{
		
	}
}
