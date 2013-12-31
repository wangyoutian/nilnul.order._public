using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T">
	/// T is defined with its essential properties. 
	/// Comparer is a deduced type of T- this means Compare is a Function from type to type. But the domain type is a type, and the image type is a dynamic type, that is, it can has many instances, depends on another dynamic parameter other than static type parameter T: TotalOrderI(T) 
	/// </typeparam>
	public partial class ComparerFroTotalOrder3<T>
		:IComparer<T>
	{
		

		private TotalOrderI3<T> _order;

		public TotalOrderI3<T> order
		{
			get { return _order; }
			set { 
				_order = value.EnsureNotNull(); }
		}
		

		public ComparerFroTotalOrder3(TotalOrderI3<T> order)
		{
			this.order = order;

		}

		public ComparerFroTotalOrder3(StrictTotalOrderI<T> strictTotalOrder)
			:this(StrictTotalToNonStrict<T>.Expr.Create(strictTotalOrder))
		{
		}
					



		public bool contains(T left,T right) {
			return order.contains(left, right);
		}
		public bool notContains(T left, T right) {
			return !contains(left, right);
		}

		public Sign compare(T x, T y)
		{
			if (contains(x, y) && contains(y, x))
			{
				return Sign.Eq;

			}
			if (contains(x, y))
			{
				return Sign.Lt;

			}
			return Sign.Gt;
		}

		#region MyRegion

		public bool gt(T x, T y)
		{
			return compare(x, y) == Sign.Gt;
		}

		public bool lt(T x, T y)
		{

			return compare(x, y) == Sign.Lt;

		}

		public bool eq(T x, T y)
		{
			return compare(x, y) == Sign.Eq;

		}

		public bool neq(T x, T y)
		{
			return !eq(x, y);

		}



		public bool ge(T x, T y)
		{
			return gt(x, y) || eq(x, y);

		}

		public bool le(T x, T y)
		{
			return lt(x, y) || eq(x, y);

		}


	
		#endregion

		static public ComparerFroTotalOrder3<T> Create(TotalOrderI3<T> order) {
			return new ComparerFroTotalOrder3<T>(order);
		
		}
		static public ComparerFroTotalOrder3<T> Create(StrictTotalOrderI<T> order)
		{
			return new ComparerFroTotalOrder3<T>(order);

		}



		public int Compare(T x, T y)
		{
			return (compare(x,y)).ToInt();
		}
	}
}
