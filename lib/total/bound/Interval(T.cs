using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.relation.order;
using nilnul.collection.set;
using nilnul.set;
using nilnul.order;
using nilnul.order.interval;
using nilnul.order.interval.cut;



namespace nilnul.order.total.bound
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
	public partial class Interval<T>
		:
		nilnul.order.total.IntervalI<T>
	//where T : IComparable<T>
		//where T:IEquatable<T>
	{

	

		#region fields
		private OrderI<T> _order;

		public OrderI<T> order
		{
			get { return _order; }
			set { _order = value.EnsureNotNull(); }
		}




		public nilnul.order.interval.Cut2<T> _left;
		public  nilnul.order.interval.Cut2<T> left
		{
			get
			{
				return _left;
			}
			set
			{
				_left = value.EnsureNotNull();
			}
		}

		private nilnul.order.interval.Cut2<T> _right;
		public nilnul.order.interval.Cut2<T> right
		{
			get
			{
				return _right;
			}
			set
			{
				_right = value.EnsureNotNull();
			}
		}

		public void set(nilnul.order.interval.Cut2<T> lowerBound, nilnul.order.interval.Cut2<T> upperBound)
		{

			//

			this.left = lowerBound;
			this.right = lowerBound;


			nilnul.bit.Assert.True(!isEmpty);


		}



		public bool isEmpty {
			get {
				
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

		public nilnul.order.total.bound.StrictFroTotal<T> strictOrder {
			get {
				return StrictFroTotal<T>.Create(order);
			}
		}



	

			#endregion




		#region ctor
		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		/// <param name="left"></param>
		/// <param name="right"></param>
		/// <remarks>If T has no instances, there will be no such interval for there is no way to provide the parameters.</remarks>
		public Interval(total.bound.OrderI<T> order, nilnul.order.interval.Cut2<T> left, nilnul.order.interval.Cut2<T> right)
		{

			this.order = order;
			set(left,right);
		}
				

		public Interval(nilnul.order.total.bound.StrictOrderI<T> order, nilnul.order.interval.Cut2<T> left,nilnul.order.interval.Cut2<T> right)
			:this(
			nilnul.order.total.bound.TotalFroStrict<T>.Create(order),
			left,
			right
			)
		{
		}

	

		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		public Interval(OrderI<T> order)
			:this(order,new nilnul.order.interval.ClosedCut<T>(order.minimum), new nilnul.order.interval.ClosedCut<T>(order.maximum))
		{
			
		}


		#endregion

		#region instance methods

		public bool isSingleton()
		{
			return left != null && right != null && left.eq && right.eq &&
				nilnul.order.total.EqualityFromTotalOrder<T>.Create(order).contains(left.pinpoint, right.pinpoint)
				;

		}

		
		public bool leftContains(T item) {
			


			return ( left.eq &&  eqaulityOfMember.contains(left.pinpoint, item) )  || 
				strictOrder.contains(left.pinpoint,item);
		
		}

		public bool eq(T a,T b) {

			return eqaulityOfMember.contains(a, b);

		
		}

		public bool rightContains(T item)
		{
			
			return (right.eq && eqaulityOfMember.contains(right.pinpoint, item) )
				|| strictOrder.contains(item, right.pinpoint);

		}


		public bool contains(T item)
		{

			return leftContains(item) && rightContains(item);

		}
		#endregion







		total.OrderI<T> IntervalI<T>.order
		{
			get { return order; }
		}
	}


}
