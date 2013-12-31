using nilnul.interval;
using nilnul.order.interval;
using System;
namespace nilnul.order.interval
{
	public partial interface IntervalI<T>
		

	{
		bool contains(T item);
		bool isSingleton();
		Cut<T> left { get; }
		nilnul.order.TotalOrderI3<T> order { get; }
		Cut<T> right { get;  }
	}
}
