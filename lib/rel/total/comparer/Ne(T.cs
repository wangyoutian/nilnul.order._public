using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.rel.total.comparer
{
	public partial class Ne<T>
		
	{
		private IComparer<T> _comparer;

		public IComparer<T> comparer
		{
			get { return _comparer; }
			set { _comparer = value; }
		}


	
		public Ne(IComparer<T> comparer)
		{
			this._comparer = comparer;

		}
					
		

		public bool contains(T first, T second)
		{
			return _comparer.Compare(first,second)!=0;
		}
	}
}
