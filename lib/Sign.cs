using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// Trichotomy 
	/// </summary>
	public enum Sign
		:int
	{
		Gt=1,
		Eq=0,
		Lt=-1
	
		
	}

	static public class SignX {

		static public int ToInt(this Sign x) {
			return (int)x;
		}
		static public Sign ToSign(this int x) {

			if (x>0)
			{
				return Sign.Gt;
				
			}
			if (x==0)
			{
				return Sign.Eq;
				
			}
			return Sign.Lt;
		
		}

		static public Sign ToSign(BigInteger x) {

			if (x>0)
			{
				return Sign.Gt;

			} if (x==0)
			{
				return Sign.Eq;
				
			}
			return Sign.Lt;
 


		
		}
	}
}
