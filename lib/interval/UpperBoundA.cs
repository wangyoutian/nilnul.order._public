using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial class UpperBoundA<T>
		:
		
		UpperBoundI<T>
	{
		public UpperBoundA(T upperBound)
		{
			this._upperBound = upperBound;

		}
		
		private T _upperBound;

		public T upperBound
		{
			get {
				return _upperBound;
				throw new NotImplementedException(); }
		}

		
		
	}
}
