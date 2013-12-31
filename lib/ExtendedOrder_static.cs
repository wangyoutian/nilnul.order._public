using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.order.extended;

namespace nilnul.order
{
	public partial class ExtendedOrderStatic<T>
		:

		OrderI<extended.ExtendedTypeI2<T>>
		
	{

		static public readonly OrderI<T> Order;//=OrderSingleton<T>.Instance;	///note, this can be assigned only onec 

		static private readonly ExtendedOrderStatic<T> _Instance = new ExtendedOrderStatic<T>();
		static public ExtendedOrderStatic<T> Instance
		{
			get
			{
				return _Instance;
			}
		}
		private ExtendedOrderStatic()
		{
		}

		static public bool Contains(extended.ExtendedTypeI2<T> a,extended.ExtendedTypeI2<T> b) {

			if (a is NegativeInfinite<T>)
			{
				if (b is extended.Literal<T>)
				{
					return true;

				}
				if (b is extended.Infinite<T>)
				{
					return true;

				}

			}
			else if (a is extended.Literal<T>)
			{
				if (b is extended.Literal<T>)
				{
					return Order.contains((a as extended.Literal<T>).literal, (b as extended.Literal<T>).literal);
				}
				if (b is Infinite<T>)
				{
					return true;

				}

			}
			return false;
		
		}


	

		
		

		

		

			


		public bool contains(extended.ExtendedTypeI2<T> item1, extended.ExtendedTypeI2<T> item2)
		{

			return Contains(item1,item2);
		}

		
	}
}
