using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer.bounded.op
{
	public partial class Intersect<T>
	{


		private IComparer<T> _comparer;

		public IComparer<T> comparer
		{
			get { return _comparer; }
			set { _comparer = value; }
		}

		public Intersect(IComparer<T> comparer)
		{
			this._comparer = comparer;

		}

		public bound.Pair<T> eval(bound.Pair<T> a,bound.Pair<T> b) {
			return new bound.Pair<T>(

				bound.LowerComparer<T>.Max(a.lower,b.lower,comparer)
				,
				bound.UpperComparer<T>.Min(a.upper,b.upper,comparer)
				
			);
		
		}
		

		
	}
}
