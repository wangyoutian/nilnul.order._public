using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.bound
{
	public partial class Id<T,TId>
		:
		Id<T>
		
		where TId:IEqualityComparer<T>,new()
	{
		
		public Id()
			:base(SingletonByDefault<TId>.Instance)
		{
			

		}
		

	
	}
}
