using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval.cut;
using nilnul.order;
using nilnul.collection.set;
using nilnul.set;
using nilnul.order;

namespace nilnul.order.interval
{

		public partial class Cut2<T>
			:CutA
			
		{

			private T _pinpoint;

			public T pinpoint
			{
				get { return _pinpoint; }
				
			}

			public T pinpoint_notNull {

				get {
					return _pinpoint;
				}
				set {
					_pinpoint=value.EnsureNotNull();
				}
			}


			public bool eq {
				get {
					return openFalseCloseTrue;
				}
			}

			public Cut2(T pinpoint, bool eq)
				:base(eq)
			{
				this.pinpoint_notNull= pinpoint;
			}


		}

	


}
