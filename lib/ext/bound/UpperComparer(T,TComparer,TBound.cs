using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.bound
{
	public partial class UpperComparer<T,TComparer,TBound>
		:IComparer<TBound>
		where TComparer:IComparer<T>
		where TBound:Bound<T>
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
		

		private order.bound.UpperComparer<ExtendedI<T>> _upperComparer;

		public order.bound.UpperComparer<ExtendedI<T>> upperComparer
		{
			get { return _upperComparer; }
		}
		
		public UpperComparer(
			TComparer elementComparer	
		)
		{
			this.elementComparer = elementComparer;
			_extendedComparer = new Comparer<T>(elementComparer);
			_upperComparer = new order.bound.UpperComparer<ExtendedI<T>>(extendedComparer);

		}

		public Bound<T> min(Bound<T> x, Bound<T> y) {

			return Compare(x, y) <= 0 ? x : y;
		
		}

		public TBound min(
			TBound x, TBound y
		)
		{

			return Compare(x, y) <= 0 ? x : y;
		}
		public TBound max(
			TBound x, TBound y
		)
		{

			return Compare(x, y) >= 0 ? x : y;
		}
		

		public int Compare(Bound<T> x, Bound<T> y)
		{
			return _upperComparer.Compare(x, y);
			
			throw new NotImplementedException();
		}

		public int Compare(TBound x, TBound y)
		{
			return Compare(x as Bound<T>, y as Bound<T>);
			throw new NotImplementedException();
		}

	}
}
