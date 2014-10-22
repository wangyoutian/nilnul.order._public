using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.op
{
	public partial class Min_ComparerSingle<T,TComparer>

		:Min<T,TComparer>
		where TComparer:IComparer<T>,new()


	{
		static public Min_ComparerSingle<T,TComparer> Singleton=SingletonByDefault<Min_ComparerSingle<T,TComparer>>.Instance;
		public Min_ComparerSingle()
			:base(SingletonByDefault<TComparer>.Instance)
		{

		}


		static public ExtendedI<T> Eval(ExtendedI<T> a, ExtendedI<T> b) {

			return Singleton.eval(a, b);
		
		}

	}
}
