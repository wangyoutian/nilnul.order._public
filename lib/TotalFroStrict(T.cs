using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public class TotalFroStrict<T>
	{




		public class Expr : 
			TotalOrderA2<T>
			,
			
			TotalOrderI3<T>

		{

			private StrictTotalOrderI<T> _order;

			public StrictTotalOrderI<T> order
			{
				get { return _order; }
				set { _order = value; }
			}

			public Expr(StrictTotalOrderI<T> order)
			{
				this.order = order;
			}



			public override bool contains(T first, T second)
			{
				return _order.contains(first,second) || object.Equals(first,second);
			}

			static public Expr Create(
				StrictTotalOrderI<T> order
				) {
					return new Expr(order);
			}

		




		}



	}
}
