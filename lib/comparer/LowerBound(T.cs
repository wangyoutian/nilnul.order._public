using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class LowerBound<T>
		
		:nilnul.collection.ContainsI<T>
	{

		private Bound<T> _lower;

		public Bound<T> lower
		{
			get { return _lower; }
			set { _lower = value; }
		}

		private IComparer<T> _comparer;

		public IComparer<T> comparer
		{
			get { return _comparer; }
			set { _comparer = value; }
		}

		public LowerBound(
			Bound<T> lower,
			IComparer<T> comparer
		)
		{
			this.lower = lower;
			this.comparer = comparer;

		}


		public bool contains(T item)
		{

			return lower.openFalseCloseTrue ? comparer.Compare(lower.pinpoint, item) <= 0 : comparer.Compare(lower.pinpoint, item) < 0;
			throw new NotImplementedException();
		}
	}
}
