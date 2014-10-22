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
	public partial class LowerBound<T,TComparer>
		:LowerBound<T>
		where TComparer:IComparer<T>,new()
	{

		public LowerBound(Cut<T> cut)
			:base(cut,SingletonByDefault<TComparer>.Instance)
		{

		}
		public LowerBound(bool openFalseCloseTrue, T pinpoint)
			:base(openFalseCloseTrue,pinpoint,SingletonByDefault<TComparer>.Instance)
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
