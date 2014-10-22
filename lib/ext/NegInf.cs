using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{
	public   partial class NegInf
		:NegInfI
	{
		static public NegInf Singleton = SingletonByDefault<NegInf>.Instance;
		public override string ToString()
		{
			return "-∞";
		}

	}
}
