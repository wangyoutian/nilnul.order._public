using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class UpperBoundComparer<T, TComparer,TCut>
		: 
		UpperBoundComparer<T,TComparer>
		,
		IComparer<TCut>
		
		
		where TComparer : IComparer<T>, new()
		where TCut:Cut<T>
	{

		static public TComparer TheComparer = SingletonByDefault<TComparer>.Instance;

		public UpperBoundComparer()
		{

		}



		public int Compare(TCut x, TCut y)
		{
			return this.Compare(x as Cut<T>, y as Cut<T>);
			throw new NotImplementedException();
		}
	}
}
