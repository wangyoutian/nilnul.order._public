using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class Interval<T>
		:

		Pair<T>
		,
		IntervalI<T>

	{
		

		
		public Interval( Cut<T> lower, Cut<T> upper,IComparer<T> comparer)
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
