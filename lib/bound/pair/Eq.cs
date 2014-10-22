using nilnul.order.bound;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.bound.pair.rel
{
	public partial class Eq<T>
		:IEqualityComparer<Pair<T>>

	{

		private IEqualityComparer<T> _elementEq;

		public IEqualityComparer<T> elementEq
		{
			get { return _elementEq; }
			set { _elementEq = value; }
		}

		public Eq(
			IEqualityComparer<T> elementEq	
		)
		{
			this.elementEq = elementEq;

		}

		public bound.Eq<T> boundEq {
			get {
				return new bound.Eq<T>(elementEq);
			}
		}
		
		
		static public bool Eval(
			Pair<T> a
			,
			Pair<T> b
			,
			IEqualityComparer<T> c

		)
		{
			var boundEq = new bound.Eq<T>(c);

			return   boundEq.Equals(a.lower, b.lower)  && boundEq.Equals(a.upper, b.upper) ;




		}

		public bool Equals(Pair<T> a, Pair<T> b)
		{
			

			return   boundEq.Equals(a.lower, b.lower)  && boundEq.Equals(a.upper, b.upper) ;


			throw new NotImplementedException();
		}

		public int GetHashCode(Pair<T> obj)
		{
			return obj.lower.GetHashCode() ^ obj.upper.GetHashCode();
			throw new NotImplementedException();
		}
	}
}
