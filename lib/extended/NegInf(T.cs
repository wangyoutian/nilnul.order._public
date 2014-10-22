using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.extended
{


	public class NegInf<T> : ExtendedTypeI2<T>, InfOrNegInfI
	{

			static private readonly NegInf<T> _Instance = new NegInf<T>();
			static public NegInf<T> Instance
			{
				get
				{
					return _Instance;
				}
			}
			private NegInf()
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
