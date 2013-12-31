using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.extended
{
	

		public class NegativeInfinite<T> : ExtendedTypeI2<T> {

			static private readonly NegativeInfinite<T> _Instance = new NegativeInfinite<T>();
			static public NegativeInfinite<T> Instance
			{
				get
				{
					return _Instance;
				}
			}
			private NegativeInfinite()
			{
			}
			public override string ToString()
			{
				return "-Infinity<"+(typeof(T)).ToString()+">";
			}


			public bool Equals(ExtendedTypeI2<T> other)
			{
				throw new NotImplementedException();
			}
		}
		
		
				


			
					
		



		




					
	
}
