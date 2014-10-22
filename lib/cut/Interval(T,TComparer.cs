using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class Interval<T,TComparer>
		:
		Interval<T>

		where TComparer:IComparer<T>,new()
	{

		
		public Interval( Cut<T> lower, Cut<T> upper)
			:base(lower,upper,SingletonByDefault<TComparer>.Instance)
		{
			

		}

		static public Interval<T, TComparer> CreateAll() {
			return new Interval<T, TComparer>(null, null);
		
		}

		static public Interval<T, TComparer> Create(Interval<T,TComparer> interval) {

			return interval==null?null: new Interval<T, TComparer>(interval.lower, interval.upper);
		
		
		}
		
		
	}
}
