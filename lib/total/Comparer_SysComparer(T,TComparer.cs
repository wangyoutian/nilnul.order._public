using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public partial class Comparer_SysComparer<T,TOrder>
		:Comparer<T,Order_FroSysComparer<T,TOrder> >
		where TOrder:IComparer<T>,new()
	{
		
	}
}
