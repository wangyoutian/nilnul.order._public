using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval
{
	public partial class Interval_froCut<T,TComparer,TCut>
		:
		Interval_froCut<T,TComparer>
		,
		IntervalI_froCut<T,TComparer,TCut>

		where TComparer:IComparer<T>,new()
		where TCut : order.cut.Cut<T>
	{

		
		public Interval_froCut( TCut lower, TCut upper)
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
