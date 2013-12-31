using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.extended
{
	

		
		public class Infinite<T>:ExtendedTypeI2<T>{

			static private readonly Infinite<T> _Instance = new Infinite<T>();
			static public Infinite<T> Instance
			{
				get
				{
					return _Instance;
				}
			}
			private Infinite()
			{
			}

			public override string ToString()
			{
				return "Infinite<"+(typeof (T)).ToString()+">";
			}







			public bool Equals(ExtendedTypeI2<T> other)
			{
				throw new NotImplementedException();
			}
		}




		




					
	
}
