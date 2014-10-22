using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{
	public partial class PosInf<T> : 
		PosInf,
		InfI<T>,PosInfI
	{
		static public PosInf<T> Singleton = SingletonByDefault<PosInf<T>>.Instance;

		
	}
}
