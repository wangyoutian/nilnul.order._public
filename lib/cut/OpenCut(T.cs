using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval.cut;
using nilnul.order;
using nilnul.collection.set;
using nilnul.set;
using nilnul.order;

namespace nilnul.order.cut
{

		public partial class OpenCut<T>
			:Cut<T>
			
		{

			

			public OpenCut(T pinpoint )
				:base(false,pinpoint)
			{
			}


		}

	


}
