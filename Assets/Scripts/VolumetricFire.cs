using UnityEngine;
using UnityEngine.Rendering;

[ExecuteAlways]
public class VolumetricFire : MonoBehaviour
{
	private Mesh mesh;

	private Material material;

	[SerializeField]
	[Range(1f, 20f)]
	[Tooltip("Controls the number of additional meshes to render in front of and behind the original mesh")]
	private int thickness;

	[SerializeField]
	[Range(0.01f, 1f)]
	[Tooltip("Controls the total distance between the frontmost mesh and the backmost mesh")]
	private float spread;

	[SerializeField]
	private bool billboard;

	private MaterialPropertyBlock materialPropertyBlock;

	private int internalCount;

	private float randomStatic;

	private Collider boundaryCollider;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private static bool IsVisible(Camera camera, Bounds bounds)
	{
		return false;
	}

	private void RenderFlames(ScriptableRenderContext context, Camera camera)
	{
	}

	private void SetupMaterialPropertyBlock(float item)
	{
	}

	private void CreateItem(float spacing, float item, Camera camera)
	{
	}
}
