using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.bounded.rel
{
	public partial class Neq<T,TComparer>
		where TComparer:IComparer<T>,new()

	{

		static public bool Eval(
			BoundedA_TSysComparer<T, TComparer> a
			,
			BoundedA_TSysComparer<T, TComparer> b


		) {
			return !Eq<T, TComparer>.Eval(a, b);
		}
	}
}
