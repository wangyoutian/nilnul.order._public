using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	public partial class Comparer<T>
		: IComparer<OrderI<T>>
		where T : IComparable<T>,IEquatable<T>
	{



		public int Compare(OrderI<T> x, OrderI<T> y)
		{
			return ComparerX<T>.Compare(x, y);

		}


	}

	static public partial class ComparerX<T>
		where T:IComparable<T>
	{
		static public readonly Type[] _echelon = new Type[]{
														  typeof( Lt<T>),
														  typeof( Le<T>),
														  typeof(Eq<T>),
														  typeof( Ge<T>),
														  typeof( Gt<T>)
													  
													  };
		static public int Compare<T>(OrderI<T> x, OrderI<T> y)
			where T:IComparable<T>
		{
			return Array.IndexOf(_echelon, (x.GetType())) - Array.IndexOf(_echelon, (y.GetType()));

		}

	}
}
