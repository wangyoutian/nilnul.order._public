using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.bound
{
	public partial class Eq_comparerSingle<T, TComparer>
		: Eq<T, TComparer>

		where TComparer : IEqualityComparer<T>, new()
	{


		static public Eq_comparerSingle<T, TComparer> Singleton = SingletonByDefault<Eq_comparerSingle<T, TComparer>>.Instance;

		public Eq_comparerSingle()
			: base(SingletonByDefault<TComparer>.Instance)
		{

		}



	}


		
}
