using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public partial class Lt_boxComparer<T,TComparer>
		:
		Lt_boxComparer<T>
		//,TotalOrderI3<T>
		where TComparer:IComparer<T>,new()
	{





		public Lt_boxComparer()
			:base(SingletonByDefaultNew<TComparer>.Instance as IComparer<T>)
		{

		}

		public class Singleton
			:SingletonByDefaultNew<Lt_boxComparer<T,TComparer>>
		{

			
		}
					

	}
}
