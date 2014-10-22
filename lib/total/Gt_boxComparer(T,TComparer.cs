using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.total
{
	public partial class Gt_boxComparer<T,TComparer>
		:
		Gt_boxComparer<T>
		//,TotalOrderI3<T>
		where TComparer:IComparer<T>,new()
	{





		public Gt_boxComparer()
			:base(SingletonByDefaultNew<TComparer>.Instance as IComparer<T>)
		{

		}

		public class Singleton
			:SingletonByDefaultNew<Gt_boxComparer<T,TComparer>>
		{

			
		}
					

	}
}
