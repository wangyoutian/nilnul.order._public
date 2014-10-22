using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut.be
{
	public partial class Negative<T>
		:nilnul.obj.BeI<Interval<T>>
	{
		static public bool Be(Interval<T> a) {
			if (a.lower==null || a.upper==null)
			{
				return false;
			}
			

			return a.comparer.Compare(a.lower.pinpoint, a.upper.pinpoint) > 0 || (
				a.comparer.Compare(a.lower.pinpoint,a.upper.pinpoint)==0
				&& 
				a.lower.openFalseCloseTrue && a.upper.openFalseCloseTrue
			);
		
		
		}
		public bool be(Interval<T> d)
		{
			return Be(d);

			throw new NotImplementedException();
		}
	}
}
