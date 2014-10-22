using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TComparer"></typeparam>
	public partial class LowerBound<T,TComparer,TCut>
		:LowerBound<T,TComparer>
		where TComparer:IComparer<T>,new()
		where TCut:Cut<T>
	{

		public LowerBound(TCut cut)
			:base(cut)
		{

		}
		public LowerBound(bool openFalseCloseTrue, T pinpoint)
			:base(openFalseCloseTrue,pinpoint)
		{

		}

		static public LowerBound<T, TComparer> Create(LowerBound<T,TComparer> a) {
			if (a.openFalseCloseTrue)
			{
				return new LowerBoundClose<T, TComparer>(a.pinpoint);
				
			}
			return new LowerBoundOpen<T, TComparer>(a.pinpoint);
		}

	}
}
