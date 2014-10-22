﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut.rel
{
	public partial class DisJoint<T,TComparer>
		:nilnul.obj.rel.ClosedI<Interval<T,TComparer>>
		where TComparer:IComparer<T>,new()
	{
		static public bool Eval(
			Interval<T,TComparer> a, Interval<T,TComparer> b
			
		) {

			return !Joint<T,TComparer>.Eval(a,b);

			throw new NotImplementedException();
		
		}

		public bool eval(Interval<T, TComparer> a, Interval<T, TComparer> b)
		{
			return Eval(a, b);
			throw new NotImplementedException();
		}
	}
}
