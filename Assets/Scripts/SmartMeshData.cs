using System.Collections.Generic;
using UnityEngine;

public class SmartMeshData
{
	private Material[] _materials;

	public Mesh mesh { get; private set; }

	public Matrix4x4 transform { get; private set; }

	public IList<Material> materials => null;

	public SmartMeshData(Mesh inMesh, Material[] inMaterials, Matrix4x4 inTransform)
	{
	}

	public SmartMeshData(Mesh inputMesh, Material[] inputMaterials)
	{
	}

	public SmartMeshData(Mesh inputMesh, Material[] inputMaterials, Vector3 position)
	{
	}

	public SmartMeshData(Mesh inputMesh, Material[] inputMaterials, Vector3 position, Quaternion rotation)
	{
	}

	public SmartMeshData(Mesh inputMesh, Material[] inputMaterials, Vector3 position, Quaternion rotation, Vector3 scale)
	{
	}
}
