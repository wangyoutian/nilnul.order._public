using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.cut
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="T"></typeparam>
	/// <typeparam name="TComparer"></typeparam>
	public partial class LowerBound<T>
		:
		Cut<T>
		,
		ComparerAsPropI<T>
		,
		nilnul.collection.ContainsI<T>
	{

		public LowerBound(Cut<T> cut,IComparer<T> comparer)
			:base(cut.openFalseCloseTrue,cut.pinpoint)
		{
			this._comparer = comparer;

		}

		public LowerBound(bool openFalseCloseTrue, T pinpoint, IComparer<T> comparer)
			:this( new Cut<T>(openFalseCloseTrue,pinpoint),comparer)
		{

		}


		private IComparer<T> _comparer;

		public IComparer<T> comparer
		{
			get {

				return _comparer;
				
				throw new NotImplementedException(); 
			
			}
			set {
				this._comparer = comparer;
			}
		}





		public bool contains(T item)
		{
			return openFalseCloseTrue ? comparer.Compare(item, pinpoint) >= 0 : comparer.Compare(item, pinpoint) > 0;
			throw new NotImplementedException();
		}
	}
}
