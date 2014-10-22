﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TComparer"></typeparam>
	public partial class LowerBoundOpen<T,TComparer>
		:LowerBound<T,TComparer>
		where TComparer:IComparer<T>,new()
	{
		public LowerBoundOpen( T pinpoint)
			:base(false,pinpoint)
		{

		}

	}
}
