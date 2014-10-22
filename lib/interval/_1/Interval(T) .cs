using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval.cut;
using nilnul.order;
using nilnul.order;

namespace nilnul.collection.interval._1
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
	//where T : IComparable<T>
	{


		#region fields
		private TotalOrderI<T> _order;

		public TotalOrderI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}







		public Cut _left;
		public Cut left
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

		private Cut _right;
		public Cut right
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

	

		public void set(Cut lowerBound, Cut upperBound)
		{

			left = lowerBound;
			right = upperBound;

		}

			#endregion




		#region ctor
			public Interval(TotalOrderI<T> order, Cut left, Cut right)
		{
			this.order = order;
			set(left,right);
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		public Interval(TotalOrderI<T> order)
		{
			set();
		}


		#endregion


		public bool leftContains(T item) {
			if (left==null)
			{
				return true;
				
			}
			return left.eq && order.eq(left.pinpoint, item) || order.gt(item,left.pinpoint);
		
		}

		public bool rightContains(T item)
		{
			if (right == null)
			{
				return true;

			}
			return right.eq && order.eq(right.pinpoint, item) || order.lt(item, right.pinpoint);

		}


		public bool contains(T item)
		{

			return leftContains(item) && rightContains(item);

		}

		#region subclass Cut
		public partial class Cut
		{
			public T pinpoint;

			public bool eq;

			

		}
		#endregion

	}


}
