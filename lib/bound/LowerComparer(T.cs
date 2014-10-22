using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.bound
{
	public partial class LowerComparer<T>
		:IComparer<Bound<T>>

	{
		static public Bound<T> Max(
			Bound<T> x
			,
			Bound<T> y
			,
			IComparer<T> comparer

			
		) {

			return  (StaticCompare(x,y,comparer)>=0)?x:y;
			
		
		
		}

		static public int  StaticCompare(
			Bound<T> x
			,
			Bound<T> y
			,
			IComparer<T> comparer
			
		) {



			return new LowerComparer<T>(comparer).Compare(x, y);





			throw new NotImplementedException();
		}

		private IComparer<T> _comparer;

		public IComparer<T> comparer
		{
			get { return _comparer; }
			set { _comparer = value; }
		}

		public LowerComparer(IComparer<T> comparer)
		{
			this._comparer = comparer;

		}
		

		public int Compare(Bound<T> x, Bound<T> y)
		{

			
			var c = comparer.Compare(x.pinpoint, y.pinpoint);

			if (c == 0)
			{
				if (x.openFalseCloseTrue && !y.openFalseCloseTrue)
				{
					return -1;

				}
				if (!x.openFalseCloseTrue && y.openFalseCloseTrue)
				{
					return 1;
				}

			}
			return c;



			throw new NotImplementedException();
		}
	}
}
