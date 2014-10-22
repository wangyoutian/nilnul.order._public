using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class UpperBound<T,TComparer,TBound>
		:
		nilnul.collection.ContainsI<T>

		where TComparer:IComparer<T>
		where TBound:Bound<T>
	{
		private TBound _upper;
		public TBound upper
		{
			get { return _upper; }
			set { _upper = value; }
		}

		private TComparer _comparer;
		public TComparer comparer
		{
			get { return _comparer; }
			set { _comparer = value; }
		}

		public UpperBound(
			TBound upper,
			TComparer comparer
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
