using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _test
{
	[TestClass]
	public class TranstiveReduce
	{
		static public bool[,] RelationMatrix1=nilnul.relation.matrix.Matrix.IntToBool(new [,]{{0, 1, 1, 0, 0},{
0, 0, 0, 0, 0},
	{0, 0, 0, 1, 1},
	{0, 0, 0, 0, 1},
	{0, 1, 0, 0, 0}});

		static public bool[,] RelationMatrix2 = nilnul.collection.matrix.IntToBoolMatrix.Eval(
			new[,]{
			{0, 1,  0, 1},
			{0, 0, 1, 0},
	{0, 0, 0, 1},
	{0, 0, 0, 0},
	}
			
			
			);


		[TestMethod]
		public void TestMethod1()
		{
			var s = nilnul.collection.matrix.MatrixX.ToString_(RelationMatrix1);
			var pathMatrix = nilnul.relation.TransitiveClosureX.Eval_warshall(RelationMatrix1);
			var reduced = nilnul.order.TransitiveReduceX.Eval(pathMatrix);
			var reduced_1 = nilnul.order.TransitiveReduceX.Eval(RelationMatrix1);
			Assert.IsTrue(nilnul.collection.matrix.MatrixX.Eq(reduced,reduced_1));

			var reduced2 = nilnul.order.TransitiveReduceX.Eval(RelationMatrix2);


			var reduced2_1 = nilnul.order.TransitiveReduceX.Eval_matrixOperations(RelationMatrix2);

			Assert.IsTrue(nilnul.collection.matrix.MatrixX.Eq(reduced2, reduced2_1));



		}
	}
}
