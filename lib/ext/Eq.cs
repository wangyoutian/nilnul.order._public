using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext
{
	public partial class Eq<T>
		:IEqualityComparer<ExtendedI<T>>
	{
		private IEqualityComparer<T> _eq;

		public IEqualityComparer<T> eq
		{
			get { return _eq; }
			set { _eq = value; }
		}

		public Eq(IEqualityComparer<T> eq)
		{
			this._eq = eq;

		}




		public bool Equals(ExtendedI<T> x, ExtendedI<T> y)
		{
			if (x is NegInf<T>)
			{
				if (y is NegInf<T>)
				{
					return true;
				}
				return false;
				
			}
			if (x is Literal<T>)
			{
				if (y is Literal<T>)
				{
					return _eq.Equals((x as Literal<T>).val, (y as Literal<T>).val);
					
				}
				return false;
				
			}
			//x is PosInf
			if (y is PosInf<T>)
			{
				return true;
				
			}
			return false;
			throw new NotImplementedException();
		}

		public int GetHashCode(ExtendedI<T> obj)
		{
			if (obj is PosInf<T>)
			{
				return int.MinValue;
				
			}
			if (obj is NegInf<T>)
			{
				return int.MaxValue;
				
			}
			return _eq.GetHashCode((obj as Literal<T>).val);
			throw new NotImplementedException();
		}
	}
}
