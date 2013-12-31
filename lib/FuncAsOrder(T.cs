using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public class FuncAsOrder<T>
		:OrderI<T>
	{

		public Func<T,T, bool> func;
		public FuncAsOrder(Func<T,T,bool> func)
		{
			this.func = func;
		}
					
		public bool contains(T first, T second)
		{
			return func(first,second);
		}
	}
}
