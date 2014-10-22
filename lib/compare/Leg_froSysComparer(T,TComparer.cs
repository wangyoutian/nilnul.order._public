using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.compare
{
	public partial class Leg_froSysComparer<T,TComparer>
		:
		Leg_froSysComparer<T>		

		where TComparer:IComparer<T>,new()
	{
		public Leg_froSysComparer()
			:base(SingletonByDefault<TComparer>.Instance)
		{

		}
	}
}
