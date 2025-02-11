using System;
using System.Runtime.InteropServices;

namespace Evergine.Bindings.TinyUSD
{
	/// <summary>
	/// Callback function for Stage's root Prim traversal.
	/// Return 1 for success, Return 0 to stop traversal futher.
	/// </summary>
	public unsafe delegate int CTinyUSDTraversalFunction(
		 IntPtr prim,
		 IntPtr path);

}
