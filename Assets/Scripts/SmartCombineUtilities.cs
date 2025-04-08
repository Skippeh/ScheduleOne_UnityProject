public static class SmartCombineUtilities
{
	private class SmartSubmeshData
	{
		public global::UnityEngine.Mesh mesh { get; private set; }

		public global::System.Collections.Generic.IList<global::UnityEngine.CombineInstance> combineInstances { get; private set; }

		public void CombineSubmeshes()
		{
		}
	}

	public static void CombineMeshesSmart(this global::UnityEngine.Mesh mesh, SmartMeshData[] meshData, out global::UnityEngine.Material[] materials)
	{
		materials = null;
	}
}
