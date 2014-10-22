using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.bound
{
	public partial class Pair<T,TBound>
		:Pair_TBound<TBound>
		where TBound: nilnul.order.Bound<T>
	{
		public Pair(TBound lower,TBound upper)
			:base(lower,upper)
		{
		}

		//public Pair(bool lowerClose,T lower, bool upperClose, T upper)
			
		//{

		//}

		public override string ToString()
		{
			return ToString(",");
		}

		public   string ToString(string separator=",")
		{
			return (lower.openFalseCloseTrue?"[":"(") +  lower.pinpoint.ToString()+separator+upper.pinpoint.ToString()+(upper.openFalseCloseTrue?"]":")");
		}


	}
}
