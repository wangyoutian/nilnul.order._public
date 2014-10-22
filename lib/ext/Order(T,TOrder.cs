using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{

	public partial class Order<T,TOrderSingleton>
		:Order<T>
		where TOrderSingleton:OrderI1<T> ,new()
	//	where T:IEquatable<T>
	{
		static public TOrderSingleton OrderOfT = SingletonByDefaultNew<TOrderSingleton>.Instance;
		

		public Order()
			: base(SingletonByDefaultNew<TOrderSingleton>.Instance)
		{
		}



		
	





		
	}
}
