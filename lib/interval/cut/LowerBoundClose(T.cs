﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.interval.cut
{
	public partial class LowerBoundClose<T>
		:ClosedCut<T>
		,
		ComparerAsPropI<T>
	{
		
		public LowerBoundClose(T benchmark, IComparer<T> comparer)
			:base(benchmark)
		{
			this._comparer = comparer;

		}

		private IComparer<T> _comparer;
		public IComparer<T> comparer
		{
			get {
				return _comparer;
				
				throw new NotImplementedException(); }
		}
	}
}
