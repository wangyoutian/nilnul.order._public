using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial class LowerBoundA<T>
		:
		
		LowerBoundI<T>
	{
		public LowerBoundA(T lower)
		{
			this._lowerBound = lower;

		}
		
		private T _lowerBound;

		public T lowerBound
		{
			get {
				return _lowerBound;
				throw new NotImplementedException(); }
		}

		
		
	}
}
