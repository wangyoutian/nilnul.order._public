using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut.interval.rel
{
	public partial class Neq
	{

		static public bool Eval<T>(
			Pair<T> a
			,
			Pair<T> b
			,
			IComparer<T> c

			
		) {


			return !Eq.Eval(a,b,c);

	
		
		}

		static public bool Eval<T>(
			Pair<T> a
			,
			Pair<T> b
			,
			IComparer<Cut<T>> c

			
		) {


			return !Eq.Eval(a,b,c);

	
		
		}



	}
}
