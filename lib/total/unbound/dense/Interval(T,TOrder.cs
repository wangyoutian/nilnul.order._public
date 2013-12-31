using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval.cut;
using nilnul.relation.order;
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
	public partial class Interval<T,TOrderSingleton>
		:nilnul.order.total.unbound.dense.Interval<T>
		where TOrderSingleton:OrderI<T>,new()
	//where T : IComparable<T>
		//where T:IEquatable<T>
	{

		public Interval(Cut2<T> left,Cut2<T> right)
			:base(SingletonByDefaultNew<TOrderSingleton>.Instance,left,right)
		{

		}

		public Interval(T left, bool leftEq, T right, bool rightEq)
			:this(new Cut2<T>( left,leftEq),new Cut2<T>(right,rightEq))
		{
		}
					
					
	}


}
