using nilnul.relation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{

	

	static public class LatticeX {

		static public IEnumerable<T> Maixmal<T>(
			
			IEnumerable<Pair<T>> lowerLattice
			
		)
 			where T:IEquatable<T>
		{

			return IntransitiveX._Maximal(lowerLattice);



		
		}

		static public class LowerSetX {
			static public IEnumerable<T> Maximal<T>(
				IEnumerable<T> lowerset,
				IEnumerable<Pair<T>> lattice

			) 
			where T:IEquatable<T>
			{
				throw new NotImplementedException();

			
			}
		
		}
	
	}
}
