using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class LowerBound_ComparerSingleton<T,TComparer,TBound>
		:
		LowerBound<T,TComparer,TBound>
		where TComparer:IComparer<T>,new()
		where TBound:Bound<T>
	{


		public LowerBound_ComparerSingleton(
			TBound lower
		)
			:base(lower,SingletonByDefault<TComparer>.Instance)
		{
			
		}
	}
}
