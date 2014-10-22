using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.bound
{
	public partial class UpperComparer_ComparerSingle<T,TComparer,TBound>
		:UpperComparer<T,TComparer,TBound>
		where TComparer:IComparer<T>,new()
		where TBound:Bound<T>
	{

		public UpperComparer_ComparerSingle()
			:base(SingletonByDefault<TComparer>.Instance)
		{

		}
		static public UpperComparer_ComparerSingle<T, TComparer, TBound> Singleton = SingletonByDefault<UpperComparer_ComparerSingle<T, TComparer, TBound>>.Instance;

		static public TBound Max(TBound x, TBound y)
		{
			return Singleton.max(x, y);

		}

		static public TBound Min(TBound x,TBound y) {
			return Singleton.min(x, y);
		}


	}
}
