using nilnul.order.total;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class AsProp<T>
		:
		AsPropI<T>
	{
		public AsProp(ComparerI3<T> comparer)
		{
			this._comparer = comparer;

		}
		private total.ComparerI3<T> _comparer;
		public total.ComparerI3<T> comparer
		{
			get {
				return _comparer;
				
				throw new NotImplementedException(); }
		}
	}
}
