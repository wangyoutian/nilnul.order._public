using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.interval
{

	/// <summary>
	/// left and right are limit.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class ClosedInterval<T>

		//:BoundedIntervalA<T>
		//,
		//ClosedIntervalI<T>
		
		where T:IComparable<T>
		
	{
		private T _left;
		public T left
		{
			get {
				return _left;
			}
			
		}

		private T _right;

		public T right
		{
			get { return _right; }
			
		}
		
		public ClosedInterval(T a,T b)
		{

			nilnul.bit.Assert.True(a.CompareTo( b)<=0);
			this._left = a;
			this._right = b;


		}

		public bool contains(T x) {
			if (x.CompareTo(left)>=0 && x.CompareTo(right) <=0)
			{
				return true;
				
			}
			return false;
		}

		public void assertContains(T x) {
			nilnul.bit.Assert.True(contains(x));
		}
	}
}
