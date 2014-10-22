using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order.ext.comparer
{
	public partial class Bounded<T,TComparer,TBound>
		:
		nilnul.order.bound.Pair<ExtendedI<T>,TBound>
		,
		nilnul.collection.ContainsI<ExtendedI<T>>

		where TComparer:IComparer<T>
		where TBound:Bound<T>

	{

		

		private TComparer _elementComparer;

		public TComparer elementComparer
		{
			get { return _elementComparer; }
			set { _elementComparer = value; }
		}


		private ext.Comparer<T> _extendedComparer;

		public ext.Comparer<T> extendedComparer
		{
			get { return _extendedComparer; }
		}


		private ext.bound.LowerComparer<T> _lowerComparer;
		public ext.bound.LowerComparer<T> lowerComparer
		{
			get {

				return _lowerComparer;
				
				
			}
		}


		private ext.bound.UpperComparer<T> _upperComparer;
		
		public ext.bound.UpperComparer<T> upperComparer
		{
			get {

				return
					_upperComparer
				
				; 
			}
		}
		
		

		public Bounded(TBound a,TBound b,TComparer c)
			:base(a,b)
			
		{
			this.elementComparer = c;
			this._extendedComparer = new Comparer<T>(c);
			this._lowerComparer = new bound.LowerComparer<T>(_elementComparer);
			this._upperComparer = new bound.UpperComparer<T>(_elementComparer);
		}





		public bool contains(ExtendedI<T> item)
		{
			return new nilnul.order.comparer.LowerBound<ExtendedI<T>>(lower,extendedComparer).contains(item) && new nilnul.order.comparer.UpperBound<ExtendedI<T>>(upper, extendedComparer).contains(item);

			throw new NotImplementedException();
		}
	}
}
