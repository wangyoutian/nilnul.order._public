using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public class OrderedList<T>
	{

		public OrderI<T> order;

		public IEnumerable<T> list;



		public OrderFullFledged<T> fullFledged ;

		

		public OrderedList(OrderI<T> order, IEnumerable<T> list)
		{
			 fullFledged = new OrderFullFledged<T>(order);

			fullFledged.assertLinear(list);
			this.list = list;

		}

		public OrderedList(Func<T,T,bool> order, IEnumerable<T> list)
			:this(new FuncAsOrder<T>(order),list)
		{
			

		}
					
	}
}
