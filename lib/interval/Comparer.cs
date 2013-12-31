using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.interval
{

	/// <summary>
	/// a comparer will make the type total ordered.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class Comparer<T>:IComparer<T>
	{

		public int Compare(T x, T y)
		{
			throw new NotImplementedException();
		}
	}
}
