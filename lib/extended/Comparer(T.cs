using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.extended
{
	public partial class Comparer<T>
		:IComparer<ExtendedTypeI2<T>>
	{
		private IComparer<T> _elementComparer;

		public IComparer<T> elementComparer
		{
			get { return _elementComparer; }
			set { _elementComparer = value; }
		}
		

		public Comparer(IComparer<T> elementComparer)
		{
			this._elementComparer = elementComparer;
		}

		public int Compare(ExtendedTypeI2<T> a, ExtendedTypeI2<T> b)
		{
			if (a is NegInf<T>)
			{
				if (b is NegInf<T>)
				{
					return 0;
					
				}

				return -1;



			}
			if (a is Literal<T>)
			{
				if (b is NegInf<T>)
				{
					return 1;
					
				}
				if (b is Literal<T>)
				{
					return elementComparer.Compare(
						(a as Literal<T>).val
						,
						(b as Literal<T>).val
					);
				}
				return -1;
				
			}
			if (b is Inf<T>)
			{
				return 0;
				
			}
			return 1;
 


			throw new NotImplementedException();
		}
	}
}
