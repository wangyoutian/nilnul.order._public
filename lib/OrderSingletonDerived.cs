using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class OrderSingletonDerived<T>
		:OrderSingletonBase<OrderSingletonDerived<T>,T>
		,
		OrderSingletonI
	{

		static private readonly OrderSingletonDerived<T> _Instance = new OrderSingletonDerived<T>();
		static public OrderSingletonDerived<T> Instance
		{
			get
			{
				return _Instance;
			}
		}

		static OrderSingletonDerived() {
			_order = Instance;
			
		}
		private OrderSingletonDerived()
		{
		}


		public bool contains(T item1, T item2)
		{
			throw new NotImplementedException();
		}

		public new OrderI<T> order
		{
			get { throw new NotImplementedException(); }
		}
	}
}
