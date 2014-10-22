using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.bound
{
	public partial class LowerComparer<T>
		:IComparer<Bound<T>>
	{
		private IComparer<T> _elementComparer;

		public IComparer<T> elementComparer
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
			IComparer<T> elementComparer	
		)
		{
			this.elementComparer = elementComparer;
			_extendedComparer = new Comparer<T>(elementComparer);
			_lowerComparer = new order.bound.LowerComparer<ExtendedI<T>>(extendedComparer);

		}
		

		public int Compare(Bound<T> x, Bound<T> y)
		{
			return _lowerComparer.Compare(x, y);
			
			throw new NotImplementedException();
		}
	}
}
