using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public class StrictFroTotal<T>
	
			:
			
			StrictTotalOrderI<T>

		{

			private TotalOrderI3<T> _order;

			public TotalOrderI3<T> order
			{
				get { return _order; }
				set { _order = value; }
			}

			public StrictFroTotal(TotalOrderI3<T> order)
			{
				this.order = order;
			}



			public  bool contains(T first, T second)
			{
				return _order.contains(first,second) && EqualityFromTotalOrder<T>.Create(order).contains(first,second);
			}


			static public StrictFroTotal<T> Create(
				TotalOrderI3<T> order
				) {
					return new StrictFroTotal<T>(order);
			}




		



	}
}
