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
	public partial class Comparer<T,TTotalOrderSingleton>
		:ComparerFroTotalOrder3<T>
		where TTotalOrderSingleton:TotalOrderI3<T>, new()
	{


		public Comparer()
			:base(new TTotalOrderSingleton())
		{
		

		}



		

		static public ComparerFroTotalOrder3<T> Create(TotalOrderI3<T> order) {
			return new ComparerFroTotalOrder3<T>(order);
		
		}
	


					

	}
}
