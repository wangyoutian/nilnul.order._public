using nilnul.interval;
using nilnul.order.interval;
using System;
namespace nilnul.order.total
{
	public partial interface IntervalI<T,TOrder>
	:nilnul.collection.set.SetI<T>	
		where TOrder:nilnul.order.total.OrderI<T>

	{
		//bool contains(T item);
		//bool isSingleton();
		Cut2<T> left { get; }
		TOrder order { get; }
		Cut2<T> right { get;  }
	}
}
