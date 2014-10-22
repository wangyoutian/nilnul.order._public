using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.compare
{
	public partial interface LegI<T>

	{

		 bool Gt(T a, T b);


		 bool Ge(T a, T b);

		 bool Lt(T a, T b);

		 bool Le(T a, T b);

		 bool Eq(T a, T b);

		 bool Neq(T a, T b);

	}
}
