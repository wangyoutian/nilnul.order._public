using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class UpperBound_ComparerSingleton<T,TComparer,TBound>
		:

		UpperBound<T,TComparer,TBound>

		where TComparer:IComparer<T>,new()
		where TBound:Bound<T>
	{

		public UpperBound_ComparerSingleton(
			TBound upper
		)
			:base(upper,SingletonByDefault<TComparer>.Instance)
			
		{
		}

	}
}
