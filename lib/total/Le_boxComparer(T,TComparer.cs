using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public partial class Le_boxComparer<T,TComparer>
		:
		Le_boxComparer<T>
		//,TotalOrderI3<T>
		where TComparer:IComparer<T>,new()
	{





		public Le_boxComparer()
			:base(SingletonByDefaultNew<TComparer>.Instance as IComparer<T>)
		{

		}

		public class Singleton
			:SingletonByDefaultNew<Le_boxComparer<T,TComparer>>
		{

			
		}
					

	}
}
