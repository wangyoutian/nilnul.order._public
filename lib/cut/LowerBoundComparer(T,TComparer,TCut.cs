using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class LowerBoundComparer<T, TComparer,TCut>
		: 

		LowerBoundComparer<T,TComparer>
		,
		IComparer<TCut>
		
		
		where TComparer : IComparer<T>, new()
		where TCut:Cut<T>
	{

		static public TComparer TheComparer = SingletonByDefault<TComparer>.Instance;

		public LowerBoundComparer()
		{

		}



		//public int Compare(TCut x, TCut y)
		//{

		//	if (x == null)
		//	{
		//		if (y == null)
		//		{
		//			return 0;

		//		}
		//		return -1;

		//	}
		//	if (y == null)
		//	{
		//		return 1;

		//	}
		//	var c = TheComparer.Compare(x.pinpoint, y.pinpoint);

		//	if (c == 0)
		//	{
		//		if (x.openFalseCloseTrue && !y.openFalseCloseTrue)
		//		{
		//			return -1;

		//		}
		//		if (!x.openFalseCloseTrue && y.openFalseCloseTrue)
		//		{
		//			return 1;
		//		}

		//	}
		//	return c;


		//	throw new NotImplementedException();
		//}

		public int Compare(TCut x, TCut y)
		{
			return Compare(x as Cut<T>, y as Cut<T>);
			throw new NotImplementedException();
		}
	}
}
