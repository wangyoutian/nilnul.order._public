using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class Pair1<T,TCut>

		:CutAsLowerI1<T,TCut>
		,CutAsUpperI1<T,TCut>
		where TCut: nilnul.order.Bound<T>
		
	{
		private TCut _upper;

		public TCut upper
		{
			get {
				return _upper;
				
				throw new NotImplementedException(); 
			
			}
		}

		private TCut _lower;
		public TCut lower
		{
			get {
				return _lower;
				throw new NotImplementedException(); 
			
			}
		}

		public Pair1(TCut lower,TCut upper)
		{
			this._lower = lower;
			this._upper = upper;

		}

		public  string ToString(string separator=",")
		{
			return (lower.openFalseCloseTrue?"[":")") +  lower.ToString()+separator+upper.ToString()+(upper.openFalseCloseTrue?")":"]");
		}


	}
}
