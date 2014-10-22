using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class Interval<T,TComparer,TCut>
		:
		Interval<T,TComparer>
		,
		IntervalI<T,TComparer,TCut>

		where TComparer:IComparer<T>,new()
		where TCut:Cut<T>
	{

		
		public Interval( TCut lower, TCut upper)
			:base(lower,upper)
		{
			

		}







		public new TCut lower
		{
			get {
				
				throw new NotImplementedException(); 
			
			}
		}

		public new TCut upper
		{
			get { throw new NotImplementedException(); }
		}

		public new TComparer comparer
		{
			get { throw new NotImplementedException(); }
		}
	}
}
