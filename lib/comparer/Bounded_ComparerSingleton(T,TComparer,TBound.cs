using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class Bounded_ComparerSingle<T,TComparer,TBound>
		:

		Bounded<T,TComparer,TBound>

		where TComparer:IComparer<T>,new()
		where TBound : order.Bound<T>
	{
		static public TComparer ElementComparer = SingletonByDefault<TComparer>.Instance;
		
		public Bounded_ComparerSingle( TBound lower, TBound upper)
			:base(lower,upper,ElementComparer)
		{
			

		}

		//public Bounded_ComparerSingle(
		//	bool lowerClose
		//	,
		//	T lower
		//	,
		//	bool upperClose
		//	,
		//	T upper
		//)
		//	:base(lowerClose,lower,upperClose,upper)
		//{

		//}

	}
}
