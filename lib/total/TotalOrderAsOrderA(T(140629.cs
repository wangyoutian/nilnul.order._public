using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public abstract partial class TotalOrderAsOrderA<T>
	{
		public TotalOrderAsOrderA(total.OrderI<T> order)
		{
			this._order = order;

		}

		private total.OrderI<T> _order;
		public total.OrderI<T> order { get {
			return _order;
		} }
	}
}
