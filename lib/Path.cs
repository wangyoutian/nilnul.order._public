using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <remarks>
	/// order.Path is never a cycle which relation.Path can be.
	/// </remarks>
	public partial class Path<T>
	{

		public OrderI<T> order;
		public List<T> nodes;

		public Path(OrderI<T> order, List<T> nodes)
		{
			for (int i = 0; i < nodes.Count-1; i++)
			{

				nilnul.bit.Assert.True(
					order.contains(nodes[i],nodes[i+1])
				);
				
			}

			this.order = order;
			this.nodes = nodes;
		}

		static public bool _Be(
			IEnumerable<T> elements_notNull
			,
			IComparer<T> comparer_notNull
			
		) {
			return nilnul.relation.PathX._Be(elements_notNull, new total.Order_FroSysComparer<T>(comparer_notNull));

		}




	}
}
