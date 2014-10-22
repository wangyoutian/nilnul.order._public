using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval.cut;
using nilnul.order;
using nilnul.collection.set;
using nilnul.set;
using nilnul.order;

namespace nilnul.order
{

		public partial class BoundA
			:BoundI
			
		{





			public BoundA(bool openFalseCloseTrue)
			{
				this._openFalseCloseTrue = openFalseCloseTrue;
				
				
			}

			private bool _openFalseCloseTrue;

			public bool openFalseCloseTrue
			{
				get {
					return _openFalseCloseTrue;
					
					throw new NotImplementedException(); 
				
				}
			}
		}

	


}
