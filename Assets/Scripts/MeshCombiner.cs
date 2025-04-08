[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.MeshFilter))]
[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.MeshRenderer))]
public class MeshCombiner : global::UnityEngine.MonoBehaviour
{
	private const int Mesh16BitBufferVertexLimit = 65535;

	[global::UnityEngine.SerializeField]
	private bool createMultiMaterialMesh;

	[global::UnityEngine.SerializeField]
	private bool combineInactiveChildren;

	[global::UnityEngine.SerializeField]
	private bool deactivateCombinedChildren;

	[global::UnityEngine.SerializeField]
	private bool deactivateCombinedChildrenMeshRenderers;

	[global::UnityEngine.SerializeField]
	private bool generateUVMap;

	[global::UnityEngine.SerializeField]
	private bool destroyCombinedChildren;

	[global::UnityEngine.SerializeField]
	private string folderPath;

	[global::UnityEngine.SerializeField]
	[global::UnityEngine.Tooltip("MeshFilters with Meshes which we don't want to combine into one Mesh.")]
	private global::UnityEngine.MeshFilter[] meshFiltersToSkip;

	public bool CreateMultiMaterialMesh
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool CombineInactiveChildren
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DeactivateCombinedChildren
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DeactivateCombinedChildrenMeshRenderers
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool GenerateUVMap
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public bool DestroyCombinedChildren
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public string FolderPath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void CheckDeactivateCombinedChildren()
	{
	}

	private void CheckDestroyCombinedChildren()
	{
	}

	public void CombineMeshes(bool showCreatedMeshInfo)
	{
	}

	private global::UnityEngine.MeshFilter[] GetMeshFiltersToCombine()
	{
		return null;
	}

	private void CombineMeshesWithSingleMaterial(bool showCreatedMeshInfo)
	{
	}

	private void CombineMeshesWithMutliMaterial(bool showCreatedMeshInfo)
	{
	}

	private void DeactivateCombinedGameObjects(global::UnityEngine.MeshFilter[] meshFilters)
	{
	}

	private void GenerateUV(global::UnityEngine.Mesh combinedMesh)
	{
	}
}
