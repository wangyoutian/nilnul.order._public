using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial interface TotalOrderedTypeI<T, TOrder>
		where TOrder : TotalOrderI2<T>, new()
	{
		TotalOrderI2<T> order
		{
			get;
		}

	}



#if DEBUG
	namespace __demo
	{

		class MyClass
		{
			
		}
		class Order:TotalOrderI2<MyClass>
		{

			public Sign compare(MyClass x, MyClass y)
			{
				throw new NotImplementedException();
			}

			public bool contains(MyClass first, MyClass second)
			{
				throw new NotImplementedException();
			}
		}



		class __Demo: TotalOrderedTypeI<MyClass,Order>
		{



			TotalOrderI2<MyClass> order
			{
				get { throw new NotImplementedException(); }
			}

			TotalOrderI2<MyClass> TotalOrderedTypeI<MyClass, Order>.order
			{
				get { throw new NotImplementedException(); }
			}
		}
	}

#endif

}
