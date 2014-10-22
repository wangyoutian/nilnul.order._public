using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public  partial class ComparerAsProp<T,TComparer>
		:ComparerAsProp<T>
		,
		
		ComparerAsPropI<T>
		where TComparer:IComparer<T>,new()
	{

		public ComparerAsProp()
			:base(SingletonByDefault<TComparer>.Instance)
		{

		}
	}
}
