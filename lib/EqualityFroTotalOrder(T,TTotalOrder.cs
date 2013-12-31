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
	public partial class EqualityFromTotalOrder<T,TTotalOrderSingleton>
		:
		nilnul.order.EqualityFromTotalOrder<T>
		
		where TTotalOrderSingleton:TotalOrderI3<T>, new()
	{

		static public TTotalOrderSingleton Order = SingletonByDefaultNew<TTotalOrderSingleton>.Instance;



		public EqualityFromTotalOrder()
			:base(Order)
		{
		}
					
		
		static public EqualityFromTotalOrder<T, TTotalOrderSingleton> Instance = SingletonByDefaultNew < EqualityFromTotalOrder<T, TTotalOrderSingleton>>.Instance;


		

	






	
	}
}
