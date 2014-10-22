using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.bound
{
	public partial class LowerComparer<T, TComparer>
		: 
		LowerComparer<T>
		
		where TComparer : IComparer<T>, new()
	{

		static public TComparer TheComparer = SingletonByDefault<TComparer>.Instance;

		static public Bound<T> Max(Bound<T> x, Bound<T> y) {

			return Max(x, y, TheComparer);
		}

		public LowerComparer()
			:base(TheComparer)
		{

		}

		
	}
}
