using nilnul.collection.set;
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
	/// 
	/// </typeparam>
	/// 
	/// <remarks>
	/// order.Path is never a cycle that relation.Path can be.
	/// </remarks>
	public partial class PathOfStrictOrder<T>
	{

		public StrictTotalOrderI<T> order;

		/// <summary>
		/// must be nonExmpty.
		/// </summary>
		public List<T> nodes;

		public PathOfStrictOrder(StrictTotalOrderI<T> order, List<T> nodes)
		{

			NonEmptyX.PredicateOfIEnumerable.assert(nodes.Cast<object>());
			for (int i = 0; i < nodes.Count-1; i++)
			{

				nilnul.bit.Assert.True(
					order.contains(nodes[i],nodes[i+1])
				);
				
			}

			this.order = order;
			this.nodes = nodes;
		}


					

	}
}
