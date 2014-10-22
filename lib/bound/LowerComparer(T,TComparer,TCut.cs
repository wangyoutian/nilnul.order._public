using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.bound
{
	public partial class LowerComparer<T, TComparer,TBound>
		: 

		LowerComparer<T,TComparer>
		,
		IComparer<TBound>
		
		
		where TComparer : IComparer<T>, new()
		where TBound:Bound<T>
	{

		static public TComparer TheComparer = SingletonByDefault<TComparer>.Instance;

		public LowerComparer()
		{

		}



	

		public int Compare(TBound x, TBound y)
		{
			return base.Compare(x as Bound<T>, y as Bound<T>);
			throw new NotImplementedException();
		}
	}
}
