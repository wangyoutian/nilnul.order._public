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

namespace nilnul.order.total.unbound
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
	public partial class Interval2<T>
		:
		
		IntervalI<T,OrderI<T>>
	//where T : IComparable<T>
		//where T:IEquatable<T>
	{


		#region fields
		private nilnul.order.total.unbound.OrderI<T> _order;

		public nilnul.order.total.unbound.OrderI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}





		public  nilnul.order.interval.Cut2<T> _left=null;
		public nilnul.order.interval.Cut2<T> left
		{
			get
			{
				return _left;
			}
			set
			{
				_left = value;
			}
		}

		private nilnul.order.interval.Cut2<T> _right=null;
		public nilnul.order.interval.Cut2<T> right
		{
			get
			{
				return _right;
			}
			set
			{
				_right = value;
			}
		}




		public void set()
		{

			left = null;
			right = null;

		}


		public bool IsEmpty {
			get {
				if (left==null || right==null)
				{
					return false;
					
				}
				if (strictOrder.contains(right.pinpoint,left.pinpoint))
				{
					return true;
					
				}
				if (eqaulityOfMember.contains(left.pinpoint,right.pinpoint))
				{
					if (left.eq && right.eq)
					{
						return false;
						
					}
					return true;
					
				}
				return false;
			}
		}

		public nilnul.order.total.EqualityFromTotalOrder<T> eqaulityOfMember {
			get {
				return new nilnul.order.total.EqualityFromTotalOrder<T>(order);
			}
		}

		public nilnul.order.total.unbound.StrictFroTotal<T> strictOrder {
			get {
				return nilnul.order.total.unbound.StrictFroTotal<T>.Create(order);
			}
		}



		public void set(nilnul.order.interval.Cut2<T> lowerBound, nilnul.order.interval.Cut2<T> upperBound)
		{

			//

			if (lowerBound!=null && upperBound!=null)
			{
				nilnul.bit.Assert.True(!IsEmpty);

				//nilnul.bit.Assert.True(
				//	order.contains(lowerBound.pinpoint, upperBound.pinpoint)
				//);
				
			}
			left = lowerBound;
			right = upperBound;

		}

			#endregion




		#region ctor
		public Interval2(nilnul.order.total.unbound.OrderI<T> order, nilnul.order.interval.Cut2<T> left, nilnul.order.interval.Cut2<T> right)
		{

			this.order = order;
			set(left, right);
		}

		public Interval2(nilnul.order.total.unbound.OrderI<T> order, T left,bool eq, T right,bool rightEq)
			:this(order,new Cut2<T>(left,eq),new Cut2<T>(right,rightEq))
		{

			
		}
				

		public Interval2(nilnul.order.total.unbound.StrictOrderI<T> order, nilnul.order.interval.Cut2<T> left,nilnul.order.interval.Cut2<T> right)
			:this(nilnul.order.total.unbound.TotalFromStrict<T>.Create(order),left,right)
		{
		}



					

	

		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		public Interval2(total.unbound.OrderI<T> order)
		{
			this.order = order;
			set();
		}


		#endregion

		#region instance methods

	

		
		public bool leftContains(T item) {
			if (left==null)
			{
				return true;
				
			}
			return left.eq && object.Equals(left.pinpoint, item)  || order.contains(left.pinpoint,item);
		
		}

		public bool rightContains(T item)
		{
			if (right == null)
			{
				return true;

			}
			return right.eq && object.Equals(right.pinpoint, item) || order.contains(item, right.pinpoint);

		}


		public bool contains(T item)
		{

			return leftContains(item) && rightContains(item);

		}
		#endregion








		//total.OrderI<T> IntervalI<T>.order
		//{
		//	get { return order; }
		//}
	}


}
