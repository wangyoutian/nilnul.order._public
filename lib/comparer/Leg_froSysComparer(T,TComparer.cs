using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.comparer
{
	public partial class Leg_froSysComparer<T,TComparer>
		:
		Leg_froSysComparer<T>		

		where TComparer:IComparer<T>,new()
	{
		public Leg_froSysComparer()
			:base(SingletonByDefault<TComparer>.Instance)
		{

		}

		static public Leg_froSysComparer<T, TComparer> Singleton = SingletonByDefault<Leg_froSysComparer<T, TComparer>>.Instance;

		static public bool Gt(T a, T b) {
			return Singleton.gt(a, b);
		}

		static public bool Ge(T a, T b) {
			return Singleton.ge(a, b);
		}
		static public bool Lt(T a, T b) {
			return Singleton.lt(a, b);
		}
		static public bool Le(T a, T b) {
			return Singleton.le(a, b);
		}
		static public bool Eq(T a, T b) {
			return Singleton.eq(a, b);
		}
		static public bool Ne(T a, T b) {
			return Singleton.ne(a, b);
		}

		static public T Max(T a, T b) {
			return Gt(a, b) ? a : b;
		}
		static public T Min(T a, T b) {
			return Lt(a, b) ? a : b;
		}




	}
}
