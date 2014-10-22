using nilnul.order.total;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.rel.total.comparer
{
	public partial class Ne<T,TComparer>
		:
		Ne<T>
		//,TotalOrderI3<T>
		where TComparer:IComparer<T>,new()
	{


		public Ne()
			:base(SingletonByDefaultNew<TComparer>.Instance as IComparer<T>)
		{

		}

		public class Singleton
			:SingletonByDefaultNew<Ne<T,TComparer>>
		{

			
		}
					

	}
}
