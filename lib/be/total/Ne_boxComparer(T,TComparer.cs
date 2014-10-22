using nilnul.order.total;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.be.total.k
{
	public partial class Ne_boxComparer<T,TComparer>
		:
		Eq_boxComparer<T>
		//,TotalOrderI3<T>
		where TComparer:IComparer<T>,new()
	{


		public Ne_boxComparer()
			:base(SingletonByDefaultNew<TComparer>.Instance as IComparer<T>)
		{

		}

		public class Singleton
			:SingletonByDefaultNew<Ne_boxComparer<T,TComparer>>
		{

			
		}
					

	}
}
