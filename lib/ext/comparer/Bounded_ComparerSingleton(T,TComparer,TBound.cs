using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.comparer
{
	public partial class Bounded_ComparerSingleton<T,TComparer,TBound>
		:
		nilnul.order.ext.comparer.Bounded<T,TComparer,TBound>
		,
		nilnul.collection.ContainsI<ExtendedI<T>>

		where TComparer:IComparer<T>,new()
		where TBound:Bound<T>

	{

		


		public Bounded_ComparerSingleton(TBound a, TBound b)
			:base(a,b ,SingletonByDefault<TComparer>.Instance)
			
		{
			

		


		}





	
	}
}
