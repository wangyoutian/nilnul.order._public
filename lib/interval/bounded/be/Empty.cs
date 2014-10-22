using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.bounded.be
{
	public partial class Empty<T>
	{
		static public bool Eval(BoundedA<T> interval) {

			return interval.comparer.Compare( interval.lowerBound , interval.upperBound)<0 
				|| 
				(interval.comparer.Compare(interval.lowerBound,interval.upperBound)==0 && 
					interval is CloseI
				);
		
		}
	}
}
