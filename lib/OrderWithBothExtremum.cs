using nilnul.relation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.order
{
	/// <summary>
	/// with both minimal and maximal.
	/// finite count of pairs
	/// 
	/// 
	/// </summary>
	/// <remarks>
	/// finite,
	/// literal,
	/// directed,
	/// acyclic, so irreflexive

	/// </remarks>
	static public partial class Order_withBothExtremum
	{
		/// <summary>
		/// 
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="directed__notNull"></param>
		/// <returns></returns>
		static public IEnumerable<IEnumerable<Pair2<T>>>     GetPaths<T>(

			IEnumerable<nilnul.relation.Pair2<T>> directed__notNull
			,IEqualityComparer<T> elementEq

		)
		{


			var paths = new List<IEnumerable<Pair2<T>>>();
			if (directed__notNull.Count() == 0)
			{
				return paths;

			}


			var head = IntransitiveDirectedX._Minimal(directed__notNull);

			var startingPath = directed__notNull.Where(c => object.Equals(c.first, head));


			foreach (var arc in startingPath)
			{

				var ideal = Ideal(directed__notNull, arc.second,elementEq);

				var subPaths = GetPaths(ideal,elementEq);
				if (subPaths.Count() == 0)
				{
					paths.Add(new[] { arc });

				}
				else
				{
					foreach (var subPath in subPaths)
					{
						paths.Add(nilnul.relation.path.Concat.Do(arc, subPath,elementEq));

					}
				}




			}

			return paths;

			throw new NotImplementedException();

		}


		static public IEnumerable<IEnumerable<Pair2<T>>> Ideal<T>(IEnumerable<Pair2<T>> directed_downward_notNull, IEnumerable<T> node_within,IEqualityComparer<T> eq)
		{
			return node_within.Select(c => Ideal(directed_downward_notNull, c,eq));

			//throw new NotImplementedException();


		}



		/// <summary>
		/// the upper set and with the maximum
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <param name="directed_downward_notNull"></param>
		/// <param name="node_within"></param>
		/// <returns></returns>

		static public IEnumerable<Pair2<T>> Ideal<T>(IEnumerable<Pair2<T>> directed_downward_notNull, T node_within, IEqualityComparer<T> eq)
		{
			var container = new Relation<T>(EqualityComparer<T>.Default);

			if (directed_downward_notNull.Count() == 0)
			{
				return new List<Pair2<T>>();

			}

			var nextArcs = RelationX.StartWith(directed_downward_notNull, node_within);

			while (nextArcs.Count() > 0)
			{
				container.addRange(
					nextArcs
				);

				var nextNodes =nilnul.relation.Range.Eval<T>(nextArcs);

				nextArcs = RelationX.StartWith(directed_downward_notNull, nextNodes);

			}

			return container;

			//throw new NotImplementedException();


		}





	}
}
