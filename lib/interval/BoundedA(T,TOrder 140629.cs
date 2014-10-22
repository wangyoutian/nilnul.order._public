using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public  abstract class BoundedA<T,TOrder>
		:
		BoundedA<T>
		,
		
		BoundedI<T>
		where TOrder:IComparer<T>,new()
		
	{

		public BoundedA( T lowerBound, T upperBound)
			:base(SingletonByDefault<TOrder>.Instance, lowerBound,upperBound)
			

		{

		}


	
	}
}
