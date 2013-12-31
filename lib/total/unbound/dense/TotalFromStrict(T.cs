using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total.unbound.dense
{
	public partial class TotalFromStrict<T>
	 :
		nilnul.order.total.TotalFroStrict<T>
		,
		nilnul.order.total.unbound.dense.OrderI<T>

		{

	

			public TotalFromStrict(StrictOrderI<T> order)
				:base(order)
			{
				
			}



			static public TotalFromStrict<T> Create(
				StrictOrderI<T> order
				) {
					return new TotalFromStrict<T>(order);
			}


		}
	}

