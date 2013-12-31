using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial class ComparerToIComparer<T>
		:IComparer<T>

	{
		private ComparerI<T> _comparer;

		public ComparerI<T> comparer
		{
			get { return _comparer; }
			set { _comparer = value; }
		}
		

		public ComparerToIComparer(
			ComparerI<T> comparer
			)
		{
			this.comparer = comparer;
		}
					

		

		 public int Compare(T x, T y)
		 {
			 return comparer.compare(x,y).ToInt();
		 }
	}
}
