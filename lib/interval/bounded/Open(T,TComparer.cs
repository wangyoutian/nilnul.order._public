using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.bounded
{
	public partial class Open<T,TComparer>
		:BoundedA_TSysComparer<T,TComparer>
		,
		OpenI
		where TComparer:IComparer<T>,new()
	{
		public Open( T lower, T upper)
			:base(lower,upper)
		{

		}
		public override bool contains(T item)
		{
			return this.comparer.Compare(lowerBound, item)<0 && this.comparer.Compare(item, upperBound)<0;

			throw new NotImplementedException();
		}
	}
}
