using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval.cut;
using nilnul.order;
using nilnul.collection.set;
using nilnul.set;
using nilnul.order;
using nilnul.collection.interval;
using nilnul.order.interval;

namespace nilnul.order.total.finite
{
	/// <summary>

	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class OpenInterval<T,TOrderSingleton>
		:
		Interval<T,TOrderSingleton>
		where TOrderSingleton:OrderI<T>,new()
	
	{

		public OpenInterval(T left,T right)
			:base( new OpenCut<T>( left),new OpenCut<T>( right))
		{
		}

	
					
					

		
	}


}
