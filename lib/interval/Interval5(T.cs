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

namespace nilnul.order.interval
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
	public partial class Interval5<T>
		:
		nilnul.order.IntervalI<T>
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

		public nilnul.order.EqualityFromTotalOrder<T> eqaulityOfMember {
			get {
				return new nilnul.order.EqualityFromTotalOrder<T>(order);
			}
		}

		public nilnul.order.StrictFroTotal<T> strictOrder {
			get {
				return StrictFroTotal<T>.Create(order);
			}
		}



		public void set(Cut lowerBound, Cut upperBound)
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
		public Interval5(TotalOrderI3<T> order, Cut left, Cut right)
		{

			this.order = order;
			set(left,right);
		}
				

		public Interval5(StrictTotalOrderI<T> order, Cut left,Cut right)
			:this(StrictTotalToNonStrict<T>.Expr.Create(order),left,right)
		{
		}


	
					


		
					
					

		/// <summary>
		/// 
		/// </summary>
		/// <param name="order"></param>
		public Interval5(TotalOrderI3<T> order)
		{
			this.order = order;
			set();
		}


		#endregion

		#region instance methods

		public bool isSingleton()
		{
			return left != null && right != null && left.eq && right.eq &&
				nilnul.order.EqualityFromTotalOrder<T>.Create(order).contains(left.pinpoint, right.pinpoint)
				;

		}

		
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

			public class EqualityComparer
			: IEqualityComparer<Cut>
			{
				public bool Equals(Cut x, Cut y)
				{
					return EqualityComparer<T>.Default.Equals(x.pinpoint, y.pinpoint) && x.eq == y.eq;

					throw new NotImplementedException();
				}

				public int GetHashCode(Cut obj)
				{
					return obj.GetHashCode() ^ obj.eq.GetHashCode();
				}
			}

			
					
					
	

		}
		#endregion



		 nilnul.order.interval.Cut<T> nilnul.order.IntervalI<T>.left
		{
			get
			{
				return new nilnul.order.interval.Cut<T>(left.pinpoint,left.eq);
			}
		
		}

		 nilnul.order.interval.Cut<T> nilnul.order.IntervalI<T>.right
		{
			get
			{
				return new nilnul.order.interval.Cut<T>(right.pinpoint,right.eq);
				throw new NotImplementedException();
			}
			
		}
	}


}
