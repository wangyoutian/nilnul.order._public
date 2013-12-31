using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total.finite
{
	public partial class TotalFromStrict<T>
	 :
		nilnul.order.total.TotalFroStrict<T,StrictOrderI<T>>
		,
		nilnul.order.total.finite.OrderI<T>
		{

			public TotalFromStrict(StrictOrderI<T> order)
				:base(order)
			{
				
			}

			static public TotalFromStrict<T> Create(
				StrictOrderI<T> order
				)
			{
				return new TotalFromStrict<T>(order);
			}




			public T maximum
			{
				get { return order.maximum; }
			}

			public T minimum
			{
				get {
					return order.minimum;
					
					throw new NotImplementedException();
				}
			}
		}
	}

