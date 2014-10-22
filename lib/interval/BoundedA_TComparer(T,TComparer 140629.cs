using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public  abstract class BoundedA_TSysComparer<T,TComparer>
		:
		BoundedA<T>
		,
		
		BoundedI<T>
		where TComparer:IComparer<T>,new()
		
	{

		public BoundedA_TSysComparer( T lowerBound, T upperBound)
			:base(SingletonByDefault<TComparer>.Instance, lowerBound,upperBound)
			

		{

		}






		
	}
}
