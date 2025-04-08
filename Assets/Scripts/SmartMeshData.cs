public class SmartMeshData
{
	private global::UnityEngine.Material[] _materials;

	public global::UnityEngine.Mesh mesh { get; private set; }

	public global::UnityEngine.Matrix4x4 transform { get; private set; }

	public global::System.Collections.Generic.IList<global::UnityEngine.Material> materials => null;

	public SmartMeshData(global::UnityEngine.Mesh inMesh, global::UnityEngine.Material[] inMaterials, global::UnityEngine.Matrix4x4 inTransform)
	{
	}

	public SmartMeshData(global::UnityEngine.Mesh inputMesh, global::UnityEngine.Material[] inputMaterials)
	{
	}

	public SmartMeshData(global::UnityEngine.Mesh inputMesh, global::UnityEngine.Material[] inputMaterials, global::UnityEngine.Vector3 position)
	{
	}

	public SmartMeshData(global::UnityEngine.Mesh inputMesh, global::UnityEngine.Material[] inputMaterials, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation)
	{
	}

	public SmartMeshData(global::UnityEngine.Mesh inputMesh, global::UnityEngine.Material[] inputMaterials, global::UnityEngine.Vector3 position, global::UnityEngine.Quaternion rotation, global::UnityEngine.Vector3 scale)
	{
	}
}
