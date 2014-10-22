using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.bound
{
	public partial class Eq<T, TComparer>
		: Eq<T>

		where TComparer : IEqualityComparer<T>
	{


		public Eq(TComparer comparer)
			: base(comparer)
		{

		}


	}	



		
}
