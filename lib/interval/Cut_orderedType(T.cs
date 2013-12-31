using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval.cut;
using nilnul.relation.order;
using nilnul.collection.set;
using nilnul.set;
using nilnul.order;

namespace nilnul.interval
{
	
	

		public partial class Cut_orderedType<TOrderedType>
			where TOrderedType:TotalOrderedTypeI
		{
			public TOrderedType pinpoint;

			public bool eq;

			public Cut_orderedType(TOrderedType pinpoint)
				:this(pinpoint,false)
			{
				
			}

			public Cut_orderedType(TOrderedType pinpoint, bool eq)
			{
				this.pinpoint = pinpoint;
				this.eq = eq;
			}
					
					
	

		}

	


}
