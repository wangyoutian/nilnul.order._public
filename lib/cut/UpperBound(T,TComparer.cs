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
	public partial class UpperBound<T,TComparer>
		:UpperBound<T>
		where TComparer:IComparer<T>,new()
	{
		public UpperBound(bool openFalseCloseTrue, T pinpoint)
			:base(openFalseCloseTrue,pinpoint,SingletonByDefault<TComparer>.Instance)
		{

		}
		public UpperBound(Cut<T> cut)
			:base(cut,SingletonByDefault<TComparer>.Instance)
		{

		}

		static public UpperBound<T, TComparer> Create(UpperBound<T,TComparer> a) {

			if (a.openFalseCloseTrue)
			{
				return new UpperBoundClose<T, TComparer>(a.pinpoint);
				
			}
			return new UpperBoundOpen<T, TComparer>(a.pinpoint);
		
		}

	}
}
