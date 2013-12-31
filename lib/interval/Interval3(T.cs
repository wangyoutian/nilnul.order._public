using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval.cut;
using nilnul.relation.order;
using nilnul.relation.order;
using nilnul.collection.set;
using nilnul.set;
using nilnul.order;

namespace nilnul.interval
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
	public partial class Interval3<T>
		:nilnul.collection.set.SetI<T>
	//where T : IComparable<T>
		//where T:IEquatable<T>
	{


		#region fields
		private TotalOrderI3<T> _order;

		public TotalOrderI3<T> order
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

			//

			if (lowerBound!=null && upperBound!=null)
			{
				nilnul.bit.Assert.True(
					order.contains(lowerBound.pinpoint, upperBound.pinpoint)
				);
				
			}
			left = lowerBound;
			right = upperBound;

		}

			#endregion




		#region ctor
		public Interval3(TotalOrderI3<T> order, Cut left, Cut right)
		{
			this.order = order;
			set(left,right);
		}
				

		public Interval3(StrictTotalOrderI<T> order, Cut left,Cut right)
			:this(StrictTotalToNonStrict<T>.Expr.Create(order),left,right)
		{
		}

		
					
					

		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		public Interval3(TotalOrderI3<T> order)
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

		

		#region subclass Cut
		public partial class Cut
		{
			public T pinpoint;

			public bool eq;

			public Cut(T pinpoint)
				:this(pinpoint,false)
			{
				
			}

			public Cut(T pinpoint, bool eq)
			{
				this.pinpoint = pinpoint;
				this.eq = eq;
			}
					
					
	

		}
		#endregion

	}


}
