using nilnul.interval;
using nilnul.order.interval;
using System;
namespace nilnul.order.total
{
	public partial interface IntervalI<T>
	:nilnul.collection.set.SetI<T>	

	{
		//bool contains(T item);
		//bool isSingleton();
		Cut2<T> left { get; }
		nilnul.order.total.OrderI<T> order { get; }
		Cut2<T> right { get;  }
	}
}
