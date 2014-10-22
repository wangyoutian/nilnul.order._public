using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.cut
{
	public partial class Upward<T>
		:nilnul.collection.ContainsI<T>
	{
		

		private Cut<T> _cut;

		public Cut<T> cut
		{
			get { return _cut; }
			set { _cut = value; }
		}

		private OrderI<T> _order;

		public OrderI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}

		public Upward(
			Cut<T> cut
			,
			OrderI<T> order
		)
		{
			this._cut = cut;
			this._order = order;

		}

	


		public bool contains(T item)
		{
			

			throw new NotImplementedException();
		}
	}
}
