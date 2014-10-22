using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class UpperBoundComparer<T>
		:IComparer<Cut<T>>
	{

		

		private IComparer<T> _comparer;

		public IComparer<T> comparer
		{
			get { return _comparer; }
			set { _comparer = value; }
		}


		private Comparer<T> _lowerBoundComparer;

		public Comparer<T> lowerBoundComparer
		{
			get { return _lowerBoundComparer; }
			private set { _lowerBoundComparer = value; }
		}
		

		public UpperBoundComparer(IComparer<T> comparer)
		{
			this._comparer = comparer;

			this._lowerBoundComparer = new Comparer<T>(  compare.Inverse<T>.Eval( comparer));

		}

		static public Cut<T> Min(Cut<T> a,Cut<T> b,IComparer<T> comparer) {

			var cutComparer = new Comparer<T>(compare.Inverse<T>.Eval(comparer));

			return cutComparer.Compare(a, b) > 0 ? b : a;




		
		}
		

		public int Compare(Cut<T> x, Cut<T> y)
		{

			return -_lowerBoundComparer.Compare(x, y);



			throw new NotImplementedException();
		}
	}
}
