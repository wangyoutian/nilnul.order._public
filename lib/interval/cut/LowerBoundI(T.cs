﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.cut
{
	public partial interface LowerBoundI<T>
		:LowerBoundI
	{

		T lowerBound { get; }
	}
}
