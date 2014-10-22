using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public  partial class ComparerSingletonAsProp<T,TComparer>
		:ComparerAsProp1<T,TComparer>
		where TComparer:IComparer<T>,new()
	{

		public ComparerSingletonAsProp()
			:base(SingletonByDefault<TComparer>.Instance)
		{

		}
	}
}
