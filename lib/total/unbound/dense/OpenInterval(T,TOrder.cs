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

namespace nilnul.order.total.unbound.dense
{
	/// <summary>
	/// one or two benchmarkers.
	/// 
	/// constructed by:
	/// one total order on type T.
	/// 
	/// the total order together with set, consititues a TotalOrderedSet.
	/// 
	/// if the set has no maximum, 
	/// 
	/// 
	/// 
	/// 
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class OpenInterval<T,TOrderSingleton>
		:nilnul.order.total.unbound.dense.Interval<T,TOrderSingleton>
		where TOrderSingleton:OrderI<T>,new()
	//where T : IComparable<T>
		//where T:IEquatable<T>
	{

		public OpenInterval(T left,T right)
			:base(new OpenCut<T>( left), new OpenCut<T>(right))
		{

		}
					
	}


}
