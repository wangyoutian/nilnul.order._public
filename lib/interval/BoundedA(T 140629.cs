using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public  abstract class BoundedA<T>
		:
		IntervalA<T>
		,
		
		BoundedI<T>
		
	{
		private T _lowerBound;
		private T _upperBound;

		public BoundedA(IComparer<T> order, T lowerBound, T upperBound)
			:base(order)

		{
			this._lowerBound = lowerBound;
			this._upperBound= upperBound;

		}
		public T upperBound
		{
			get {
				return _lowerBound;
				
				throw new NotImplementedException(); }
		}

		public T lowerBound
		{
			get {
				return _upperBound;
				
				throw new NotImplementedException(); }
		}




		
	}
}
