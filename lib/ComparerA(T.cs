using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public abstract partial class ComparerA<T>
		:ComparerI<T>
		,IComparer<T>
		
	{



		public abstract Sign compare(T x, T y);



		#region MyRegion

		public bool gt(T x, T y)
		{
			return compare(x, y) == Sign.Gt;
		}

		public bool lt(T x, T y)
		{

			return compare(x, y) == Sign.Lt;

		}

		public bool eq(T x, T y)
		{
			return compare(x, y) == Sign.Eq;

		}

		public bool neq(T x, T y)
		{
			return !eq(x, y);

		}



		public bool ge(T x, T y)
		{
			return gt(x, y) || eq(x, y);

		}

		public bool le(T x, T y)
		{
			return lt(x, y) || eq(x, y);

		}



		#endregion





		public int Compare(T x, T y)
		{
			return compare(x,y).ToInt();
		}
	}
}
