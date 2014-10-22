using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public  partial class ComparerAsProp1<T,TComparer>
		:ComparerAsPropI<T,TComparer>
		where TComparer:IComparer<T>
	{

		private TComparer _comparer;


		public ComparerAsProp1(TComparer comparer)

		{
			this._comparer = comparer;

		}



		public TComparer comparer
		{
			get {
				return _comparer;
				throw new NotImplementedException();
			
			}
		}
	}
}
