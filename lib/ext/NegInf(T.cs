using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{
	public partial class NegInf<T> :

		NegInf
		,
		
		InfI<T>,NegInfI
	{
		static public NegInf<T> Singleton = SingletonByDefault<NegInf<T>>.Instance;

		
		public override string ToString()
		{
			return "-∞";
		}
	}
}
