using nilnul.collection.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public class OrderedSet<TElement>
	{
		private SetI<TElement> _set;

		public SetI<TElement> set
		{
			get { return _set; }
			set { _set = value; }
		}

		private OrderI<TElement> _order;

		public OrderI<TElement> order
		{
			get { return _order; }
			set { _order = value; }
		}
		
		

		/// <summary>
		/// ordered set is a 2 tuple. 
		/// </summary>
		/// <param name="set"></param>
		/// <param name="order"></param>
		public OrderedSet(SetI<TElement> set, OrderI<TElement> order )
		{
			this.set = set;
			this.order = order;
		}
					
	}
}
