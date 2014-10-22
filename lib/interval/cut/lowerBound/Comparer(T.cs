using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.cut.lowerBound
{
	public partial class Comparer<T,TComparer>
		:IComparer<cut.LowerBoundI<T,TComparer>>
		where TComparer:IComparer<T>,new()
	{

		static public TComparer TheComparer = SingletonByDefault<TComparer>.Instance;
		
		public int Compare(LowerBoundI<T, TComparer> x, LowerBoundI<T, TComparer> y)
		{
			var c = TheComparer.Compare(x.lowerBound, y.lowerBound);

			if (c==0)
			{
				if (x is LowerBoundCloseI && y is LowerBoundOpenI)
				{
					return 1;
					
				}
				if (x is LowerBoundOpenI && y is LowerBoundCloseI)
				{
					return -1;
				}
				
			}
			return c;

			throw new NotImplementedException();
		}
	}
}
