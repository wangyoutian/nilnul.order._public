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
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Interval2<T>
		:
		
		nilnul.order.total.Interval<T,OrderI<T>>
	//where T : IComparable<T>
		//where T:IEquatable<T>
	{


		#region ctor
		public Interval2(nilnul.order.total.unbound.dense.OrderI<T> order, nilnul.order.interval.Cut2<T> left, nilnul.order.interval.Cut2<T> right)
			:base(order,left,right)
		{

			
		}
				

		public Interval2(nilnul.order.total.unbound.dense.StrictOrderI<T> order, nilnul.order.interval.Cut2<T> left,nilnul.order.interval.Cut2<T> right)
			:this(nilnul.order.total.unbound.dense.TotalFromStrict<T>.Create(order),left,right)
		{
		}


	
					


		
					
					

		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		public Interval2(OrderI<T> order)
			:base(order)
		{
			
		}


		#endregion










		public Cut2<T> left
		{
			get { throw new NotImplementedException(); }
		}

		public OrderI<T> order
		{
			get { throw new NotImplementedException(); }
		}

		public Cut2<T> right
		{
			get { throw new NotImplementedException(); }
		}

		public bool contains(T a)
		{
			throw new NotImplementedException();
		}
	}


}
