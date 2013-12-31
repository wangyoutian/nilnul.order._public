﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.interval
{

	/// <summary>
	/// left and right are limit.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class ClosedInterval3<T>

		: Interval4<T>
		
		
	{


		public ClosedInterval3(nilnul.order.TotalOrderI3<T> order,  T a, T b)
			: base(
			order
			,
			new Cut(a, true),
			new Cut(b, true)


			)
		{



		}

		public ClosedInterval3(nilnul.order.StrictTotalOrderI<T> order, T a, T b)
			: base(
			order
			,
			new Cut(a, true),
			new Cut(b, true)


			)
		{



		}


	}
}
