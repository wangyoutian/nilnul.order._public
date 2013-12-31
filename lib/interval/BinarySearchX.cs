using nilnul.order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.interval
{
	public partial class BinarySearchX
	{
		/// <summary>
		/// don't use this, which is not finished.
		/// </summary>
		/// <typeparam name="T"></typeparam>
		/// <typeparam name="TTotalOrder"></typeparam>
		/// <param name="element"></param>
		/// <param name="path"></param>
		/// <returns></returns>
		static public Interval4<T> BinarySearch<T,TTotalOrder>(T element, PathOfStrictOrder<T> path)
			where TTotalOrder:TotalOrderI3<T>,new()
		
		{

			var totalOrder = StrictTotalToNonStrict<T>.Expr.Create(path.order);
			var totalOrderAssertion = ComparerFroTotalOrder3<T>.Create(totalOrder);

			if (path.order.contains(element,path.nodes.First()))
			{
				return new Interval4<T>(
					new StrictTotalToNonStrict<T>.Expr( path.order),
					null, 
					new Interval4<T>.Cut(path.nodes.First()));

				
			}

			if (totalOrderAssertion.eq(element,path.nodes.First()))
			{
				return new ClosedInterval2<T, TTotalOrder>(element, element);

				
			}



			if (path.order.contains(path.nodes.Last(),element))
			{
				return new Interval4<T>(
					new StrictTotalToNonStrict<T>.Expr(path.order),
					
					new Interval4<T>.Cut(path.nodes.First())
					,
					null
				);


			}

			if (totalOrderAssertion.eq(element,path.nodes.First()))
			{
				return new ClosedInterval2<T, TTotalOrder>(element, element);
	
			}

			var index=path.nodes.BinarySearch(element, ComparerFroTotalOrder3<T>.Create(path.order));


			if (index>=0)
			{

				
			}

			//get the middle point.





			throw new NotImplementedException();
		}

		static public Interval4<T> BinarySearchX_ListBiSearch<T, TTotalOrder>(T element, PathOfStrictOrder<T> path)
	where TTotalOrder : TotalOrderI3<T>, new()
		{

			var index = path.nodes.BinarySearch(element, ComparerFroTotalOrder3<T>.Create(path.order));
			if (index >= 0)
			{
				return  new ClosedInterval3<T>(
					path.order,
					path.nodes[index],
					path.nodes[index]
				);

			}
			var indexComplement = ~index;
			if (indexComplement==path.nodes.Count)
			{
				return new OpenUpperInterval3<T>(path.order, path.nodes.Last());
				
			}
			if (indexComplement==0)
			{
				return new OpenLowerInterval3<T>(path.order,path.nodes.First());
				
			}

			return new ClosedInterval3<T>(path.order,path.nodes[indexComplement-1],path.nodes[indexComplement]);

			//get the middle point.


			throw new NotImplementedException();
		}



		static public Interval4<T> BinarySearchX_ListBiSearch<T, TTotalOrder>(T element, List<T> nodes,TotalOrderI3<T> order)
	
		{

			var index = nodes.BinarySearch(element, ComparerFroTotalOrder3<T>.Create(order));
			if (index >= 0)
			{
				return new ClosedInterval3<T>(
					order,
					nodes[index],
					nodes[index]
				);

			}
			var indexComplement = ~index;
			if (indexComplement == nodes.Count)
			{
				return new OpenUpperInterval3<T>(order, nodes.Last());

			}
			if (indexComplement == 0)
			{
				return new OpenLowerInterval3<T>(order, nodes.First());

			}

			return new ClosedInterval3<T>(order, nodes[indexComplement - 1], nodes[indexComplement]);

			//get the middle point.


			throw new NotImplementedException();
		}


		static public Interval4<T> BinarySearchX_ListBiSearch<T>(T element, List<T> nodes, ComparerI<T> comparer)
		{

			var index = nodes.BinarySearch(element, new ComparerToIComparer<T>(comparer));

			var order = new nilnul.order.ComparerAsOrder<T>(comparer);
			if (index >= 0)
			{
				return new ClosedInterval3<T>(
					order,
					nodes[index],
					nodes[index]
				);

			}
			var indexComplement = ~index;
			if (indexComplement == nodes.Count)
			{
				return new OpenUpperInterval3<T>(order, nodes.Last());

			}
			if (indexComplement == 0)
			{
				return new OpenLowerInterval3<T>(order, nodes.First());

			}

			return new ClosedInterval3<T>(order, nodes[indexComplement - 1], nodes[indexComplement]);

			//get the middle point.


			throw new NotImplementedException();
		}


		static public Tuple<int?,int?> BinarySearchX_ListBiSearch_index<T>(T element, List<T> nodes, ComparerI<T> comparer)
		{

			var index = nodes.BinarySearch(element, new ComparerToIComparer<T>(comparer));

			var order = new nilnul.order.ComparerAsOrder<T>(comparer);
			if (index >= 0)
			{
				return new Tuple<int?,int?>(
					index,
					index
				);

			}
			var indexComplement = ~index;
			if (indexComplement == nodes.Count)
			{
				return new Tuple<int?,int?>( indexComplement-1,null);

			}
			if (indexComplement == 0)
			{
				return new Tuple<int?,int?>(null,0);

			}

			return new Tuple<int?,int?>( indexComplement - 1, indexComplement);

			//get the middle point.


			throw new NotImplementedException();
		}

	}
}
