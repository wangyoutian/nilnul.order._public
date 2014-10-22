using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.compare
{
	public partial class Inverse<T>
	{
		static public Expr Eval(IComparer<T> comparer ) {
			return new Expr(comparer);
		
		}

		public partial class Expr
			:IComparer<T>
		{
			private IComparer<T> _comparer;

			public IComparer<T> comparer
			{
				get { return _comparer; }
				set { _comparer = value; }
			}
			public Expr(IComparer<T> comparer)
			{
				this._comparer = comparer;

			}



			public int Compare(T x, T y)
			{
				return -_comparer.Compare(x, y);
				throw new NotImplementedException();
			}
		}
		public partial class Expr<TComparer> : Expr
	where TComparer : IComparer<T>, new()
		{
			public Expr()
				: base(SingletonByDefault<TComparer>.Instance)
			{

			}

		}

	}
}
