using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nilnul.relation.comparison
{
	/// <summary>
	/// return bool?
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public interface CompareI<TLeft, TRight> : BinaryOpI<TLeft, TRight, bool>
	{

	}
}
