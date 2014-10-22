using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class Pair1<T>

		
		
	{
		private order.Bound<T> _upper;

		public order.Bound<T> upper
		{
			get {
				return _upper;
				
				throw new NotImplementedException(); 
			
			}
		}

		private order.Bound<T> _lower;
		public order.Bound<T> lower
		{
			get {
				return _lower;
				throw new NotImplementedException(); 
			
			}
		}

		public Pair1(order.Bound<T> lower,order.Bound<T> upper)
		{
			this._lower = lower;
			this._upper = upper;

		}

		public Pair1(Cut<T> lower, Cut<T> upper)
			:
			this(
			new order.Bound<T>(lower.openFalseCloseTrue,lower.pinpoint),
			new order.Bound<T>(upper.openFalseCloseTrue,upper.pinpoint)
			)
		{

		}
	}
}
