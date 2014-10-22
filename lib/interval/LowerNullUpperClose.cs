using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial class LowerNullUpperClose<T>
		:
		IntervalA<T>
		,
		
		UpperBoundI<T>
		
	{
		public LowerNullUpperClose(IComparer<T> comparer, T upperBound)
			:base(comparer)
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

		public override bool contains(T item)
		{
			return comparer.Compare(item, _upperBound)<=0;
			throw new NotImplementedException();
		}

		
	}
}
