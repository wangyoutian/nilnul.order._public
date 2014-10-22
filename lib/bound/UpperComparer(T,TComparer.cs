using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.bound
{
	public partial class UpperComparer<T, TComparer>
		: 
		UpperComparer<T>
		
		where TComparer : IComparer<T>, new()
	{

		static public TComparer TheComparer = SingletonByDefault<TComparer>.Instance;

		static public Bound<T> Min(Bound<T> a,Bound<T> b) {

			return Min(a, b, TheComparer);

		
		}

		public UpperComparer()
			:base(TheComparer)
		{

		}

		
	}
}
