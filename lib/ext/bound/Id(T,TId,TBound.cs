using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.bound
{
	public partial class Id<T,TId,TBound>
		:
		
		IEqualityComparer<TBound>
		
		where TId:IEqualityComparer<T>,new()
		where TBound:Bound<T>
	{

		static public Id<T, TId, TBound> Singleton = SingletonByDefault<Id<T, TId, TBound>>.Instance;

		static public TId ElementId = SingletonByDefault<TId>.Instance;

		static public ext.Eq<T,TId> ExtendedId = Eq<T, TId>.Singleton;

		private TId _elementId;

		public TId elementId
		{
			get { return _elementId; }
			set { _elementId = value; }
		}
		
		
		public Id()
			
		{

			

		}




		public bool Equals(TBound x, TBound y)
		{
			return ExtendedId.Equals(x.pinpoint, y.pinpoint) && x.openFalseCloseTrue == y.openFalseCloseTrue;

			throw new NotImplementedException();
		}
		static public bool Eval(TBound x, TBound y)
		{
			return ExtendedId.Equals(x.pinpoint, y.pinpoint) && x.openFalseCloseTrue == y.openFalseCloseTrue;

			throw new NotImplementedException();
		}

		public int GetHashCode(TBound obj)
		{
			return obj.openFalseCloseTrue.GetHashCode() ^ obj.pinpoint.GetHashCode();

			throw new NotImplementedException();
		}
	}
}
