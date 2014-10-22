using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using nilnul.collection.interval.cut;
using nilnul.order;
using nilnul.collection.set;
using nilnul.set;
using nilnul.order;

namespace nilnul.interval
{
	/// <summary>
	/// 
	/// </summary>
	/// <typeparam name="TOrderedType"></typeparam>
	/// 
	[Obsolete("not yet finished.We need the element type, but it's not presented.")]
	
	public partial class Interval_orderedType<TOrderedType>
		where TOrderedType:TotalOrderedTypeI
	{

		private Cut_orderedType<TOrderedType> _left;

		public Cut_orderedType<TOrderedType> left
		{
			get { return _left; }
			set { _left = value; }
		}
		private Cut_orderedType<TOrderedType> _right;

		public Cut_orderedType<TOrderedType> right
		{
			get { return _right; }
			set { _right = value; }
		}
	

		#region ctor
		public Interval_orderedType(Cut_orderedType<TOrderedType> left,Cut_orderedType<TOrderedType> right)
			
		{
			this.left = left;
			this.right = right;

		
			
		}
	

		#endregion

		

		

	

	}


}
