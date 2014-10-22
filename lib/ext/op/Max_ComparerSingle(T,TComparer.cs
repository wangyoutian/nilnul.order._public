using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.op
{
	public partial class Max_ComparerSingle<T,TComparer>

		:Max<T,TComparer>
		where TComparer:IComparer<T>,new()


	{
		static public Max_ComparerSingle<T,TComparer> Singleton=SingletonByDefault<Max_ComparerSingle<T,TComparer>>.Instance;
		public Max_ComparerSingle()
			:base(SingletonByDefault<TComparer>.Instance)
		{

		}


		static public ExtendedI<T> Eval(ExtendedI<T> a, ExtendedI<T> b) {

			return Singleton.eval(a, b);
		
		}

	}
}
