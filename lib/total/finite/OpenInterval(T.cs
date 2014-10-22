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
	public partial class OpenInterval<T>
		:
		Interval<T>
	//where T : IComparable<T>
		//where T:IEquatable<T>
	{



		#region ctor
		public OpenInterval(nilnul.order.total.finite.OrderI<T> order,T left, T right)
			:base(order,new OpenCut<T>( left), new OpenCut<T>(right))
		{

			
		}
				

		public OpenInterval(nilnul.order.total.finite.StrictOrderI<T> order, T left,T right)
			:this(nilnul.order.total.finite.TotalFromStrict<T>.Create(order),left,right)
		{
		}

	

		#endregion

		

	


	}




}
