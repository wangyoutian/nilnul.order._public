using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.bound
{
	public partial class Eq<T>
		:IEqualityComparer<Bound<T>>
	{
		private IEqualityComparer<T> _elementEq;

		public IEqualityComparer<T> elementEq
		{
			get { return _elementEq; }
			set { _elementEq = value; }
		}

		public Eq(IEqualityComparer<T> elementEq)
		{
			this.elementEq = elementEq;

		}


		



		public bool Equals(Bound<T> x, Bound<T> y)
		{
			return elementEq.Equals(x.pinpoint, y.pinpoint) && x.openFalseCloseTrue == y.openFalseCloseTrue;

			throw new NotImplementedException();
		}

		public int GetHashCode(Bound<T> obj)
		{
			return obj.openFalseCloseTrue.GetHashCode() ^ obj.pinpoint.GetHashCode();
			throw new NotImplementedException();
		}
	}
}
