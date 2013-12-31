using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// This is static order in that it has only one instance, so the type and the order has no difference. you use the type, then you have the instance.
	/// </summary>
	public  partial class OrderSingleton<T>
		:OrderI<T>
		where T:IEquatable<T>
	{

		static private readonly OrderSingleton<T> _Instance = new OrderSingleton<T>();
		static public OrderSingleton<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		/// <summary>
		/// no constructor, the logic is statically defined.
		/// </summary>
		private OrderSingleton()
		{
		}

		static public bool Contains(T item1, T item2) {
			throw new Exception("This is a demo. Write your own.");
		}


		public virtual bool contains(T item1, T item2)
		{
			return Contains(item1,item2);
		}

		
	}
}
