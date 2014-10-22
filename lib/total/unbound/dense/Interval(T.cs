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
	
	public partial class Interval<T>
		:nilnul.order.total.unbound.Interval<T>
	//where T : IComparable<T>
		//where T:IEquatable<T>
	{


		#region ctor
		public Interval(nilnul.order.total.unbound.OrderI<T> order, nilnul.order.interval.Cut2<T> left, nilnul.order.interval.Cut2<T> right)
			:base(order,left,right)
		{

			
		}
				

		public Interval(nilnul.order.total.unbound.StrictOrderI<T> order, nilnul.order.interval.Cut2<T> left,nilnul.order.interval.Cut2<T> right)
			:this(nilnul.order.total.unbound.TotalFromStrict<T>.Create(order),left,right)
		{
		}


	
					


		
					
					

		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		public Interval(total.unbound.OrderI<T> order)
			:base(order)
		{
			this.order = order;
			set();
		}


		#endregion









	}


}
