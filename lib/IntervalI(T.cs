using nilnul.interval;
using nilnul.order.interval;
using System;
namespace nilnul.order
{
	public partial interface IntervalI<T>
	:nilnul.collection.set.SetI<T>	

	{
		//bool contains(T item);
		bool isSingleton();
		nilnul.order.interval.Cut<T> left { get; }
		nilnul.order.TotalOrderI3<T> order { get; }
		interval.Cut<T> right { get;  }
	}
}
