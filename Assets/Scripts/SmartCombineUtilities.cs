using System.Collections.Generic;
using UnityEngine;

public static class SmartCombineUtilities
{
	private class SmartSubmeshData
	{
		public Mesh mesh { get; private set; }

		public IList<CombineInstance> combineInstances { get; private set; }

		public void CombineSubmeshes()
		{
		}
	}

	public static void CombineMeshesSmart(this Mesh mesh, SmartMeshData[] meshData, out Material[] materials)
	{
		materials = null;
	}
}
