using nilnul.order.cut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial class Interval_froCut<T>
		:

		Pair<T>
		,
		IntervalI_froCut<T>

	{



		public Interval_froCut(order.cut.Cut<T> lower, order.cut.Cut<T> upper, IComparer<T> comparer)
			:base(lower,upper)
		{
			_comparer = comparer;
			

		}



		public bool contains(T item)
		{
			//var lowerBound = new LowerBound<T>(lower, comparer);
			//var upperBound = new UpperBound<T>(upper, comparer);

			return ( lower==null?true: new LowerBound<T>(lower, comparer).contains(item)
				)
				&& 
				(
				  upper==null?true:new UpperBound<T>(upper, comparer).contains(item)
			);

			throw new NotImplementedException();
		}


		private IComparer<T> _comparer;

		public IComparer<T> comparer
		{
			get { 
				return _comparer;
				
				throw new NotImplementedException(); 
			
			}
		}

		
	}
}
