using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{
	public partial class Comparer<T,TElementComparer>
		:
		Comparer<T>
		
		//IComparer<ExtendedTypeI2<T>>
		where TElementComparer:IComparer<T>,new()
	{

		static public Comparer<T, TElementComparer> Singleton = SingletonByDefault<Comparer<T, TElementComparer>>.Instance;
		public Comparer()
			:base(
				SingletonByDefault<TElementComparer>.Instance
			)
		{

		}
		
	}
}
