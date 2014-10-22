using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.bounded.op
{
	public partial class Intersect<T,TComparer>
		where TComparer:IComparer<T>,new()
	{
		static public IComparer<T> Comparer = SingletonByDefault<TComparer>.Instance;

		static public BoundedA<T> Eval(
			BoundedA_TSysComparer<T,TComparer> a
			,
			BoundedA_TSysComparer<T,TComparer> b
		){



			throw new NotImplementedException();
		}
	}
}
