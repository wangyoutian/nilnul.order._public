using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.bound
{
	public partial class UpperComparer<T, TComparer,TBound>
		: 
		UpperComparer<T,TComparer>
		,
		IComparer<TBound>
		
		
		where TComparer : IComparer<T>, new()
		where TBound:Bound<T>
	{

		static public TComparer TheComparer = SingletonByDefault<TComparer>.Instance;

		public UpperComparer()
		{

		}



		public int Compare(TBound x, TBound y)
		{
			return base.Compare(x as Bound<T>, y as Bound<T>);
			throw new NotImplementedException();
		}
	}
}
