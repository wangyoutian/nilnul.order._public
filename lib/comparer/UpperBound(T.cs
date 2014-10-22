using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class UpperBound<T>
		
		:nilnul.collection.ContainsI<T>
	{

		private Bound<T> _upper;

		public Bound<T> upper
		{
			get { return _upper; }
			set { _upper = value; }
		}

		private IComparer<T> _comparer;

		public IComparer<T> comparer
		{
			get { return _comparer; }
			set { _comparer = value; }
		}

		public UpperBound(
			Bound<T> upper,
			IComparer<T> comparer
		)
		{
			this.upper = upper;
			this.comparer = comparer;

		}


		public bool contains(T item)
		{

			return upper.openFalseCloseTrue ? comparer.Compare(item,upper.pinpoint) <= 0 : comparer.Compare(item,upper.pinpoint) < 0;
			throw new NotImplementedException();
		}
	}
}
