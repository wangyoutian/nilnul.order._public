using nilnul.order.total;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.be.total
{
	public partial class Eq_boxComparer<T,TComparer>
		:
		Eq_boxComparer<T>
		//,TotalOrderI3<T>
		where TComparer:IComparer<T>,new()
	{


		public Eq_boxComparer()
			:base(SingletonByDefaultNew<TComparer>.Instance as IComparer<T>)
		{

		}

		public class Singleton
			:SingletonByDefaultNew<Eq_boxComparer<T,TComparer>>
		{

			
		}
					

	}
}
