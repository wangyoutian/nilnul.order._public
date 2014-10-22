using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.bound
{
	public partial class LowerComparer_ComparerSingle<T,TComparer,TBound>
		:LowerComparer<T,TComparer,TBound>
		where TComparer:IComparer<T>,new()
		where TBound:Bound<T>
	{

		public LowerComparer_ComparerSingle()
			:base(SingletonByDefault<TComparer>.Instance)
		{

		}


		static public LowerComparer_ComparerSingle<T, TComparer, TBound> Singleton = SingletonByDefault<LowerComparer_ComparerSingle<T, TComparer, TBound>>.Instance;

		static public TBound Max(TBound x, TBound y) {
			return Singleton.max(x, y);
		
		}
	}
}
