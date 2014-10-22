using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class LowerBoundComparer<T, TComparer>
		: 
		LowerBoundComparer<T>
		
		where TComparer : IComparer<T>, new()
	{

		static public TComparer TheComparer = SingletonByDefault<TComparer>.Instance;

		static public Cut<T> Max(Cut<T> x, Cut<T> y) {

			return Max(x, y, TheComparer);
		}

		public LowerBoundComparer()
			:base(TheComparer)
		{

		}

		
	}
}
