using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.bound
{
	public partial class UpperComparer<T>
		:IComparer<Bound<T>>
	{
		private IComparer<T> _comparer;
		public IComparer<T> comparer
		{
			get { return _comparer; }
			set { _comparer = value; }
		}

	
		
		public UpperComparer(IComparer<T> comparer)
		{
			this._comparer = comparer;
		}

		static public Bound<T> Min(Bound<T> a,Bound<T> b,IComparer<T> comparer) {
			return new UpperComparer<T>(comparer).Compare(a,b)>0?b:a;
		}


		public int Compare(Bound<T> x, Bound<T> y)
		{

			var c = comparer.Compare(x.pinpoint, y.pinpoint);

			if (c == 0)
			{
				if (x.openFalseCloseTrue && !y.openFalseCloseTrue)
				{
					return 1;

				}
				if (!x.openFalseCloseTrue && y.openFalseCloseTrue)
				{
					return -1;
				}

			}
			return c;

			//return -_lowerBoundComparer.Compare(x, y);



			throw new NotImplementedException();
		}
	}
}
