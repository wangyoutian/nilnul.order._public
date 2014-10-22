using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{
	public partial class Comparer<T,TElementComparer,TExt>
		
		:


		
		IComparer<TExt>
		
		//IComparer<ExtendedTypeI2<T>>
		where TElementComparer:IComparer<T>,new()
		where TExt:ExtendedI<T>
	{

		static public Comparer<T, TElementComparer> Singleton = SingletonByDefault<Comparer<T, TElementComparer>>.Instance;
		


		public int Compare(TExt x, TExt y)
		{
			return Singleton.Compare(x, y);

			throw new NotImplementedException();
		}

		public int Compare(TExt x, T y)
		{
			return Singleton.Compare(x as ExtendedI<T>, new Literal<T>(y) as ExtendedI<T>);
		}
		public int Compare(ExtendedI<T> x, T y)
		{
			return Singleton.Compare(x as ExtendedI<T>, new Literal<T>(y) as ExtendedI<T>);
		}
		public int Compare(ExtendedI<T> x, ExtendedI<T> y)
		{
			return Singleton.Compare(x , y );
		}
		public int Compare(T x, T y)
		{
			return Singleton.Compare( new Literal<T>(x) as ExtendedI<T>, new Literal<T>(y) as ExtendedI<T>);
		}

	}
}
