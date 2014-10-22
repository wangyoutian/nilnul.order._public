using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.bound
{
	public partial class Id<T>
		:IEqualityComparer<Bound<T>>
	{
		private IEqualityComparer<T> _elementId;

		public IEqualityComparer<T> elementId
		{
			get { return _elementId; }
			set { _elementId = value; }
		}

		private ext.Eq<T> _boundId;

		public ext.Eq<T> boundIdGet(){
			return new Eq<T>(_elementId);
		}

		public Id(IEqualityComparer<T> elementId)
		{
			this._elementId = elementId;
			_boundId = boundIdGet();

		}
		

		public bool Equals(Bound<T> x, Bound<T> y)
		{
			return _boundId.Equals(x.pinpoint, y.pinpoint) && x.openFalseCloseTrue == y.openFalseCloseTrue;

			throw new NotImplementedException();
		}

		public int GetHashCode(Bound<T> obj)
		{
			return obj.openFalseCloseTrue.GetHashCode() ^ obj.pinpoint.GetHashCode();
			throw new NotImplementedException();
		}
	}
}
