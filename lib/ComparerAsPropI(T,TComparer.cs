using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public  partial interface ComparerAsPropI<T,TComparer>
		
		where TComparer:IComparer<T>
	{

		TComparer comparer { get; }
	}
}
