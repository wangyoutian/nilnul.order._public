using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class Bounded<T,TComparer,TBound>
		:
		bound.Pair<T,TBound>
		,
		nilnul.collection.ContainsI<T>

		where TComparer:IComparer<T>
		where TBound : order.Bound<T>
	{

		private TComparer _elementComparer;

		public TComparer elementComparer
		{
			get { return _elementComparer; }
			set { _elementComparer = value; }
		}
		
		public Bounded( TBound lower, TBound upper,TComparer comparer)
			:base(lower,upper)
		{
			this.elementComparer = comparer;

		}
		//public Bounded(bool lowerClose, T lower, bool upperClose, T upper)
		//	:base(lowerClose,lower,upperClose,upper)
		//{

		//}

		public bool contains(T item)
		{
			return new LowerBound<T, TComparer, TBound>(lower,elementComparer).contains(item)
				&&

			new UpperBound<T, TComparer, TBound>(upper,elementComparer).contains(item)
			;
			throw new NotImplementedException();
		}
	}
}
