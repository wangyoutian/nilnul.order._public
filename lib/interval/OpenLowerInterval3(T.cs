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
	public partial class OpenLowerInterval3<T>

		: Interval4<T>
	{


		public OpenLowerInterval3(nilnul.order.TotalOrderI3<T> order, T a)
			: base(
			order
			,
			null,

			new Cut(a, false)


			)
		{



		}

		public OpenLowerInterval3(nilnul.order.StrictTotalOrderI<T> order, T a)
		: this(
			nilnul.order.StrictTotalToNonStrict<T>.Expr.Create(order)
			,
			a
		)
		{



		}


	}
}
