using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class Comparer<T, TComparer>
		: 
		Comparer<T>
		
		where TComparer : IComparer<T>, new()
	{
		static public Comparer<T, TComparer> Singleton = SingletonByDefault<Comparer<T, TComparer>>.Instance;

		static public TComparer ElementComparer = SingletonByDefault<TComparer>.Instance;

		public Comparer()
			:base(ElementComparer)
		{

		}

		
	}
}
