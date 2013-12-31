using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{

	public partial class Comparer_byIComparable<T>
		: ComparerI<T>
		where T : IComparable<T>
	{


					


		public Sign compare(T x,T y)
		{
			return  x.CompareTo(y).ToSign();

		}



	
	}

	
}
