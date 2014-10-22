using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{
	public   partial class PosInf
		:PosInfI
	{
		static public PosInf Singleton = SingletonByDefault<PosInf>.Instance;
		public override string ToString()
		{
			return "+∞";
		}

	}
}
