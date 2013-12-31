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
	/// <typeparam name="TTotalOrderSingleton"></typeparam>
	public partial class NonEqualityFromEquality<T>
		:
		nilnul.relation.func.NegateResult<T>
		
		
		
	{

		public NonEqualityFromEquality(EqualityI<T> eq)
			:base(eq)
		{
		}
					

		static public NonEqualityFromEquality<T> Create(EqualityI<T> order){

			return new NonEqualityFromEquality<T>(order);
		}






	
	}
}
