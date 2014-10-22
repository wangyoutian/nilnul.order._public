﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.cut
{
	public partial class LowerBoundOpen<T,TComparer>
		:LowerBoundOpen<T>
		where TComparer:IComparer<T>,new()
	{
		
		public LowerBoundOpen(T benchmark)
			:base(benchmark,SingletonByDefault<TComparer>.Instance)
		{

		}

		
	}
}
