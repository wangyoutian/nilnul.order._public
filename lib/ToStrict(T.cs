using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class ToStrict<T>
		:order.StrictI
	{
		private OrderI<T> _order;

		public OrderI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}
		

		public ToStrict(OrderI<T> order)
		{
			this.order = order;
		}

					
	}
}
