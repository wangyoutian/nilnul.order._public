using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.extended
{



	public class Inf<T> : ExtendedTypeI2<T>, InfOrNegInfI
		
		{

			static private readonly Inf<T> _Instance = new Inf<T>();
			static public Inf<T> Instance
			{
				get
				{
					return _Instance;
				}
			}
			private Inf()
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
