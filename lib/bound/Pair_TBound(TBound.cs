using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.bound
{
	public partial class Pair_TBound<TBound>
	{
		private TBound _upper;

		public TBound upper
		{
			get {
				return _upper;
				
				throw new NotImplementedException(); 
			
			}
		}

		private TBound _lower;
		public TBound lower
		{
			get {
				return _lower;
				throw new NotImplementedException(); 
			
			}
		}

		public Pair_TBound(TBound lower,TBound upper)
		{
			this._lower = lower;
			this._upper = upper;

		}

		public override string ToString()
		{
			return string.Format("{0},{1}",lower.ToString(),upper.ToString());
		}



	}
}
