using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.cut.op
{
	public partial class Intersect<T,TComparer>
		where TComparer:IComparer<T>,new()
	{
		static public bool Eval(
			Cut2<T> a,
			Cut2<T> b
		) {

			throw new NotImplementedException();
		}
	}
}
