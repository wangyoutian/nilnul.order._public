using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial class LowerOpenUpperNull<T>
		:
		IntervalA<T>
		,
		
		LowerBoundI<T>
	{
		public LowerOpenUpperNull(IComparer<T> comparer, T lowerBound)
			:base(comparer)
		{
			this._lowerBound = lowerBound;

		}
		private T _lowerBound;

		public T lowerBound
		{
			get {
				return _lowerBound;
				throw new NotImplementedException(); }
		}

		public override bool contains(T item)
		{
			return comparer.Compare( _lowerBound,item)<=0;
			throw new NotImplementedException();
		}

		
	}
}
