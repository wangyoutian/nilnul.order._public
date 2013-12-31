using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.order;
using nilnul.relation.order;

namespace nilnul.collection.interval.cut
{
	public partial class Cut_TotalOrderedSet<T>
	{
		private TotalOrderI<T> _order;

		

		public nilnul.order.TotalOrderI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}

		private bool _eq;

		public bool eq
		{
			get { return _eq; }
			set { _eq = value; }
		}

		private bool _upper;

		public bool upper
		{
			get { return _upper; }
			set { _upper = value; }
		}
		
		

		private T _pinpoint;

		public T pinpoint
		{
			get { return _pinpoint; }
			set { _pinpoint = value; }
		}
		

		public Cut_TotalOrderedSet(T benchmark, TotalOrderI<T> comparer,bool eq,bool directionUpperLower)
		{
			this._pinpoint = benchmark;
			this._order = comparer;
			this.upper = directionUpperLower;
			this.eq = eq;

		}

		public bool contains(T item) {
			return eq && order.eq(item, pinpoint) || upper ? order.gt(item, pinpoint):order.lt(item,pinpoint);
	
		}

		public bool notContains(T item) {
			return !contains(item);
		
		}

					
	}
}
