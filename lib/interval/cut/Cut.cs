using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.order;

namespace nilnul.collection.interval.cut
{
	[Obsolete("nilnul.order.interval.cut")]
	public partial class Cut<T>
		where T:IComparable<T>
	{
		private TotalI<T> _order;

		public TotalI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}

		private T _pinpoint;

		public T pinpoint
		{
			get { return _pinpoint; }
			set { _pinpoint = value; }
		}
		

		public Cut(T benchmark, TotalI<T> comparer)
		{
			this._pinpoint = benchmark;
			this._order = comparer;

		}

		public bool contains(T item) {
			return order.contains(item,pinpoint);
		
		}

		public bool notContains(T item) {
			return !contains(item);
		
		}



					
	}
}
