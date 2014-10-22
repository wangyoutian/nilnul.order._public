using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public  partial class ComparerAsProp<T>
		:ComparerAsPropI<T>
	{

		public ComparerAsProp(IComparer<T> comparer)
		{
			this._comparer = comparer;

		}
		private IComparer<T> _comparer;

		public IComparer<T> comparer
		{
			get { throw new NotImplementedException(); }
		}
	}
}
