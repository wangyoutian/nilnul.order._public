using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial class Interval_froCut<T,TComparer>
		:
		Interval_froCut<T>

		where TComparer:IComparer<T>,new()
	{


		public Interval_froCut(order.cut.Cut<T> lower, order.cut.Cut<T> upper)
			:base(lower,upper,SingletonByDefault<TComparer>.Instance)
		{
			

		}

		static public Interval_froCut<T, TComparer> CreateAll() {
			return new Interval_froCut<T, TComparer>(null, null);
		
		}

		static public Interval_froCut<T, TComparer> Create(Interval_froCut<T,TComparer> interval) {

			return interval==null?null: new Interval_froCut<T, TComparer>(interval.lower, interval.upper);
		
		
		}
		
		
	}
}
