using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public partial interface TotalOrderAsOrderI<T>
	{
		total.OrderI<T> order { get; }
	}
}
