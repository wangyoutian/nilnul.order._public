using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.op
{
	public partial class Max<T,TComparer>

		:nilnul.obj.op.binary.ClosedI<ExtendedI<T>>
		where TComparer:IComparer<T>


	{
		private TComparer _comparer;

		public TComparer comparer
		{
			get { return _comparer; }
			set { _comparer = value; }
		}

		private Comparer<T> _extendedComparer;

		public Comparer<T> extendedComparer
		{
			get { return _extendedComparer; }
		}
		
		
		public Max(TComparer comparer)
		{
			this.comparer = comparer;
			this._extendedComparer = new Comparer<T>(comparer);


		}


	

		public ExtendedI<T> eval(ExtendedI<T> a, ExtendedI<T> b)
		{
			return _extendedComparer.Compare(a, b) > 0 ? a : b;
			throw new NotImplementedException();
		}
	}
}
