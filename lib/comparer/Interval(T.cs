using nilnul.order.cut;
using nilnul.order.interval;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class Interval<T>
		:

		Pair<T>
		,
		IntervalI<T>

	{



		public Interval(order.cut.Cut<T> lower, order.cut.Cut<T> upper, IComparer<T> comparer)
			:base(lower,upper)
		{
			_comparer = comparer;
			

		}

		public Interval(
			order.Bound<T> lower
			,
			order.Bound<T> upper
			,
			IComparer<T> comparer
		)
			:this(
				new order.cut.Cut<T>(lower)
				,
				new order.cut.Cut<T>(upper)
				,
				comparer
			)

		{

		}



		public bool contains(T item)
		{
			//var lowerBound = new LowerBound<T>(lower, comparer);
			//var upperBound = new UpperBound<T>(upper, comparer);

			return ( lower==null?true: new cut.LowerBound<T>(lower, comparer).contains(item)
				)
				&& 
				(
				  upper==null?true:new cut.UpperBound<T>(upper, comparer).contains(item)
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
