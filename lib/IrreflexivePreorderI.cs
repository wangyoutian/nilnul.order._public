using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.order
{
	/// <summary>
	/// This ,in fact , is Transitive. And because it's irreflexive, so it will not produce cycluar realtions.
	/// </summary>
	public partial interface IrreflexivePreorderI 
		:
		nilnul.order.PreorderI
		
	{
	}
}
