using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// if T is infinite, i.e., with no maximal, this will be the artificial object to stand for the maximum. Note: this maximu is for the > relation only. No eq is defined on this (it's incomparable to itself.).
	/// 
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// Then an order can be defined on T, and Infinite(T) as follows a set that's the union of
	/// Linear(T), {obj| obj is T}*{  Infinte(T)}
	/// </remarks>
	public partial class Infinite_ofOrder<T>
		:
		InfiniteI<T>
		
	{
		private UnboundI<T> _order;

		public UnboundI<T> order
		{
			get { return _order; }
			set { _order = value; }
		}
		

		/// <summary>
		/// if an order is defined on type T, and the order is unbound, then we can define an Infinite
		/// </summary>
		/// <param name="order"></param>
		public Infinite_ofOrder(UnboundI<T> order)
		{


		}
					


	}
}
