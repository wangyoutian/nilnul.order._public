using System;
namespace nilnul.order
{
	public partial interface TotalOrderI<T>
	{
		Sign compare(T x, T y);
		bool eq(T x, T y);
		bool ge(T x, T y);
		bool gt(T x, T y);
		bool le(T x, T y);
		bool lt(T x, T y);
		bool neq(T x, T y);
	}
}
