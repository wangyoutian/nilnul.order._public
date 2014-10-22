using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.order.extended;

namespace nilnul.order.extended
{

	public partial class Order<T,TOrderSingleton>
		:Order<T>
		where TOrderSingleton:OrderI<T> ,new()
	//	where T:IEquatable<T>
	{
		static public TOrderSingleton OrderOfT = SingletonByDefaultNew<TOrderSingleton>.Instance;
		

		public Order()
			: base(SingletonByDefaultNew<TOrderSingleton>.Instance)
		{
		}



		
	





		
	}
}
