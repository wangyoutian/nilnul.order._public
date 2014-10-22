using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.bound
{
	public partial class LowerComparer<T,TComparer>
		:IComparer<Bound<T>>
		where TComparer:IComparer<T>
	{
		private TComparer _elementComparer;

		public TComparer elementComparer
		{
			get { return _elementComparer; }
			set { _elementComparer = value; }
		}

		private ext.Comparer<T> _extendedComparer;

		public ext.Comparer<T> extendedComparer
		{
			get { return _extendedComparer; }
		}
		

		private order.bound.LowerComparer<ExtendedI<T>> _lowerComparer;

		public order.bound.LowerComparer<ExtendedI<T>> lowerComparer
		{
			get { return _lowerComparer; }
		}
		
		public LowerComparer(
			TComparer elementComparer	
		)
		{
			this.elementComparer = elementComparer;
			_extendedComparer = new Comparer<T>(elementComparer);
			_lowerComparer = new order.bound.LowerComparer<ExtendedI<T>>(extendedComparer);

		}

		public Bound<T> min(Bound<T> x, Bound<T> y) {

			return Compare(x, y) <= 0 ? x : y;
		
		}
		

		public int Compare(Bound<T> x, Bound<T> y)
		{
			return _lowerComparer.Compare(x, y);
			
			throw new NotImplementedException();
		}
	}
}
