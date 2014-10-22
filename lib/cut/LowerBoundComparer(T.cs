﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	public partial class LowerBoundComparer<T>
		:IComparer<Cut<T>>

	{
		static public Cut<T> Max(
			Cut<T> x
			,
			Cut<T> y
			,
			IComparer<T> comparer

			
		) {

			return  (StaticCompare(x,y,comparer)>=0)?x:y;
			
		
		
		}

		static public int  StaticCompare(
			Cut<T> x
			,
			Cut<T> y
			,
			IComparer<T> comparer
			
		) {

			if (x == null)
			{
				if (y == null)
				{
					return 0;

				}
				return -1;

			}
			if (y == null)
			{
				return 1;

			}
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

		private IComparer<T> _comparer;

		public IComparer<T> comparer
		{
			get { return _comparer; }
			set { _comparer = value; }
		}

		public LowerBoundComparer(IComparer<T> comparer)
		{
			this._comparer = comparer;

		}
		

		public int Compare(Cut<T> x, Cut<T> y)
		{

			if (x==null)
			{
				if (y==null)
				{
					return 0;
					
				}
				return -1;
				
			}
			if (y==null)
			{
				return 1;
				
			}
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
