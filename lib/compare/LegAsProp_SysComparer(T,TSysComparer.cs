using nilnul.order.total;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.compare
{
	public partial class LegAsProp_SysComparer<T,TComparer>
		:
		LegAsProp<T,Leg_froSysComparer<T,TComparer> >
		where TComparer:IComparer<T>,new()
	{
		
	}
}
