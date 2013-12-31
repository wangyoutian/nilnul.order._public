using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// a class with only single instance. then the class can be fed into another class that will consume that single instance; thus make the second class a type dependent on the instance, hence a dynamic type.
	/// It's the developer's responsibility to gurantee the first class is singleton. There is no mechanism in C# to verify a static class conforms to certain rules.
	/// </summary>
	public partial interface OrderSingletonI<T>
		:OrderI<T>
		where T:IEquatable<T>
	{
		OrderI<T> order
		{
			get;
		}

	}
}
