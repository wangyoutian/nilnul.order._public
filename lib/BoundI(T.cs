﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial interface BoundI<T>
		:BoundI
	{
		T pinpoint { get; }
	}
}
