using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class Pair<T>

		:CutAsLowerBoundI<T>
		,CutAsUpperBoundI<T>
		
	{
		private Cut<T> _upper;

		public Cut<T> upper
		{
			get {
				return _upper;
				
				throw new NotImplementedException(); 
			
			}
		}

		private Cut<T> _lower;
		public Cut<T> lower
		{
			get {
				return _lower;
				throw new NotImplementedException(); 
			
			}
		}

		public Pair(Cut<T> lower,Cut<T> upper)
		{
			this._lower = lower;
			this._upper = upper;

		}

		public Pair(order.Bound<T> lower, order.Bound<T> upper)
			:this(new Cut<T>(lower.openFalseCloseTrue,lower.pinpoint),new Cut<T>(upper.openFalseCloseTrue,upper.pinpoint))
		{

		}
	}
}
