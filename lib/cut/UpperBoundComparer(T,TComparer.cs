using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class UpperBoundComparer<T, TComparer>
		: 
		UpperBoundComparer<T>
		
		where TComparer : IComparer<T>, new()
	{

		static public TComparer TheComparer = SingletonByDefault<TComparer>.Instance;

		static public Cut<T> Min(Cut<T> a,Cut<T> b) {

			return Min(a, b, TheComparer);

		
		}

		public UpperBoundComparer()
			:base(TheComparer)
		{

		}

		
	}
}
