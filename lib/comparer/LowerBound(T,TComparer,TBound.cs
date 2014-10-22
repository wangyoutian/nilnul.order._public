using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class LowerBound<T,TComparer,TBound>
		:
		nilnul.collection.ContainsI<T>

		where TComparer:IComparer<T>
		where TBound:Bound<T>
	{
		private TBound _lower;
		public TBound lower
		{
			get { return _lower; }
			set { _lower = value; }
		}

		private TComparer _comparer;
		public TComparer comparer
		{
			get { return _comparer; }
			set { _comparer = value; }
		}

		public LowerBound(
			TBound lower,
			TComparer comparer
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
