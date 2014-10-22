using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial interface LegI<T>

	{

		 bool gt(T a, T b);


		 bool ge(T a, T b);

		 bool lt(T a, T b);

		 bool le(T a, T b);

		 bool eq(T a, T b);

		 bool ne(T a, T b);


	}
}
