using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class OrderedType<T,OrderSingleton>
		where OrderSingleton:OrderSingleton<T>
		where T:IEquatable<T>

	{
		//static public OrderSingletonDerived<T> order = OrderSingletonDerived<T>.Instance;	//todo: this is a demo.
		static public OrderSingleton<T> order = OrderSingleton<T>.Instance;	//todo: this is a demo.



		static OrderedType(){

	
		}

		private T _val;

		public T val
		{
			get { return _val; }
			set { _val = value; }
		}

		
		public OrderedType(T val)
		{
			this.val = val;
		}
					
		
	}
}
