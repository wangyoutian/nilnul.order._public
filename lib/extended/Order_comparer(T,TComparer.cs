using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.order.extended;

namespace nilnul.order.extended
{

	public partial class Order_comparer<T,TComparerSingleton>
		:Order<T>
		where TComparerSingleton:IComparer<T> ,new()
	//	where T:IEquatable<T>
	{
		static public TComparerSingleton Comparer = SingletonByDefaultNew<TComparerSingleton>.Instance;

		static public nilnul.order.total.Order_FroSysComparer<T> Order = new total.Order_FroSysComparer<T>(Comparer as IComparer<T>);
		

		public Order_comparer()
			:base(total.Le_boxComparer<T,TComparerSingleton>.Singleton.Instance)
		{

		}
		
	}
}
