using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.interval
{

	/// <summary>
	/// left and right are limit.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class ClosedInterval2<T, TTotalOrder>

		: Interval4<T>
		
		where TTotalOrder : nilnul.order.TotalOrderI3<T>, new()
	{


		public ClosedInterval2(T a, T b)
			: base(
			new TTotalOrder()
			,
			new Cut(a, true),
			new Cut(b, true)


			)
		{



		}


	}
}
