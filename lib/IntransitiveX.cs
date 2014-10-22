using nilnul.relation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// intransitive(n) when n!=1.
	/// 
	/// </summary>
	/// <remarks>
	/// finite,
	/// literal,
	/// directed,
	/// acyclic, so irreflexive

	/// </remarks>
	static public partial class IntransitiveX
	{

		static public HashSet<T> _Maximal<T>(
			IEnumerable<nilnul.relation.Pair<T>> nodes

		)
	
		{


			var r = RelationX.Range(nodes);

			var domain = RelationX.Domain(nodes);

			r.ExceptWith(domain);
			return r;


		}


		static public HashSet<T> _Maximal<T>(
	IEnumerable<nilnul.relation.Pair2<T>> nodes

)
		{


			var r = relation.Range.Eval(nodes);

			var domain = RelationX.Domain(nodes);

			r.ExceptWith(domain);
			return r;


		}


		static public HashSet<T> _Minimal<T>(
			IEnumerable<nilnul.relation.Pair<T>> nodes
		)
			
		{
			return _Maximal(nodes.Select(c => c.inverse()));
		}


		



		static public IEnumerable<Pair2<T>> _Filter<T>(
			IEnumerable<T> _ideal
			,
			Lattice<T> lattice
			)
		where T : IEquatable<T>
		{

			return lattice.Where(c => !_ideal.Contains(c.first) && !_ideal.Contains(c.second));



		}

		[Obsolete("wrong")]
		static public IEnumerable<T> _MaximalNexts<T>(
			IEnumerable<Pair<T>> graph,
			IEnumerable<T> maximals
			
		){
			return graph.Where(c => maximals.Contains(c.second) ).Select(c => c.first);

			//return graph.Where(c => maximals.Contains(c.second) && !maximals.Contains(c.first)).Select(c => c.second);
		
		}

		static public HashSet<T> _MaximalNexts_hashset<T>(
		IEnumerable<Pair<T>> graph,
		IEnumerable<T> maximals

	)
		{
			return new HashSet<T>(graph.Where(c => maximals.Contains(c.second)).Select(c => c.first));

			//return graph.Where(c => maximals.Contains(c.second) && !maximals.Contains(c.first)).Select(c => c.second);

		}
		static public HashSet<T> _MaximalNexts_hashset2<T>(
		IEnumerable<Pair2<T>> graph,
		IEnumerable<T> maximals

	)
		{
			return new HashSet<T>(graph.Where(c => maximals.Contains(c.second)).Select(c => c.first));

			//return graph.Where(c => maximals.Contains(c.second) && !maximals.Contains(c.first)).Select(c => c.second);

		}

		static public IEnumerable<T> _MinimalNexts<T>(
		IEnumerable<Pair<T>> graph,
		IEnumerable<T> minimals

	)
		{
			return graph.Where(c => minimals.Contains(c.first)).Select(c => c.second);
			//			return graph.Where(c => minimals.Contains(c.first) && !minimals.Contains(c.second)).Select(c => c.second);

		}

		static public HashSet<T> _MinimalSubsequents_hashset<T>(
IEnumerable<Pair<T>> graph,
IEnumerable<T> minimals
		)
		{
			return new HashSet<T>( graph.Where(c => minimals.Contains(c.first)).Select(c => c.second));
		}

		static public HashSet<T> _MinimalSubsequents_hashset<T>(
IEnumerable<Pair2<T>> graph,
IEnumerable<T> minimals
)
		{
			return new HashSet<T>(graph.Where(c => minimals.Contains(c.first)).Select(c => c.second));
		}


		static public IEnumerable<T> _Maximal<T>(
			IEnumerable<Pair<T>> lowerSet,
			IEnumerable<T> seeped
		)
			where T : IEquatable<T>
		{

			return seeped.Where(c => IsMaximal(lowerSet, c));


		}

		static public IEnumerable<T> _Minimals<T>(
	IEnumerable<Pair<T>> graph,
	IEnumerable<T> seeped
)
	
		{

			return seeped.Where(c => IsMinimal(graph, c));


		}

		static public bool IsMinimal<T>(
		IEnumerable<Pair<T>> graph,
		T seeped

	)
	
		{
			return !graph.Any(c => c.second.Equals(seeped));



		}

		static public bool IsMaximal<T>(
			IEnumerable<Pair<T>> lowerDag,
			T seeped

		)
		where T : IEquatable<T>
		{
			return !lowerDag.Any(c => c.first.Equals(seeped));



		}



		static public IEnumerable<Pair<T>> _Sub<T>(
			IEnumerable<T> nodes
			,

			IEnumerable<Pair<T>> dag
	)
		where T : IEquatable<T>
		{
			return dag.Where(c => (nodes.Contains(c.first) && nodes.Contains(c.second)));
		}




		static public IEnumerable<Pair<T>> _RemainedArcs<T>(
			IEnumerable<T> removedNodes
		,
		IEnumerable<Pair<T>> dag
	)
		where T : IEquatable<T>
		{
			return dag.Where(c => (!removedNodes.Contains(c.first) && !removedNodes.Contains(c.second)));
		}


		static public IEnumerable<Pair<T>> _RemainedArcs2<T>(
		IEnumerable<Pair<T>> dag,
			IEnumerable<T> removedNodes

	)
		where T : IEquatable<T>
		{
			return dag.Where(
				c => (
						!(
							removedNodes.Contains(c.first)
							||
							removedNodes.Contains(c.second)
						)
				)
			);
		}

		static public IEnumerable<Pair2<T>> _RemainedArcs3<T>(
		IEnumerable<Pair2<T>> dag,
			IEnumerable<T> removedNodes

	)
		where T : IEquatable<T>
		{
			return dag.Where(
				c => (
						!(
							removedNodes.Contains(c.first)
							||
							removedNodes.Contains(c.second)
						)
				)
			);
		}

		static public class BiggerSetX
		{



			static public IEnumerable<T> _Neximal<T>(
				IEnumerable<T> biggerSet
				,
				IEnumerable<Pair<T>> dag

			)
			where T : IEquatable<T>
			{

				return IntransitiveX._Maximal(
					IntransitiveX._RemainedArcs(biggerSet, dag)
				);

			}

			static public IEnumerable<T> _Neximal<T>(
					IEnumerable<Pair<T>> dag,
					IEnumerable<T> biggerSet
					,
					IEnumerable<T> seepings

				)
				where T : IEquatable<T>
			{
				return IntransitiveX._Maximal( IntransitiveX._RemainedArcs2(dag, biggerSet),seepings);

			}

			



			static public IEnumerable<T> _Minimal<T>(
				IEnumerable<T> biggerSet
				,
				IEnumerable<Pair<T>> dag

			)
			where T : IEquatable<T>
			{

				return IntransitiveX._Minimal(

					IntransitiveX._Sub(biggerSet, dag)
				);



			}


		}




		static public class SmallerSetX
		{



			static public IEnumerable<T> _Neximal<T>(
			IEnumerable<T> lowerSet
			,
			IEnumerable<Pair<T>> dag

		)
		where T : IEquatable<T>
			{

				return IntransitiveX._Minimal(
					IntransitiveX._RemainedArcs(lowerSet, dag)
				);



			}



			static public IEnumerable<T> _Maximal<T>(
				IEnumerable<T> lowerSet
				,
				IEnumerable<Pair<T>> dag

			)
			where T : IEquatable<T>
			{

				return IntransitiveX._Maximal(

			dag.Where(c => (lowerSet.Contains(c.first) && lowerSet.Contains(c.second))));



			}







		}




	}	//class DagX
}	//namespace nilnul.order
