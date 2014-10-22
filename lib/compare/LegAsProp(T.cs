using nilnul.order.total;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.compare
{
	public partial class LegAsProp<T>
		:
		LegAsPropI<T>
	{
		public LegAsProp(LegI<T> comparer)
		{
			this._comparer = comparer;

		}

		private LegI<T> _comparer;
		

		public LegI<T> comparer
		{
			get { 
				return _comparer;

				throw new NotImplementedException(); }
		}
	}
}
