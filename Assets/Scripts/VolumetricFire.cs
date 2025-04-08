[global::UnityEngine.ExecuteAlways]
public class VolumetricFire : global::UnityEngine.MonoBehaviour
{
	private global::UnityEngine.Mesh mesh;

	private global::UnityEngine.Material material;

	[global::UnityEngine.SerializeField]
	[global::UnityEngine.Range(1f, 20f)]
	[global::UnityEngine.Tooltip("Controls the number of additional meshes to render in front of and behind the original mesh")]
	private int thickness;

	[global::UnityEngine.SerializeField]
	[global::UnityEngine.Range(0.01f, 1f)]
	[global::UnityEngine.Tooltip("Controls the total distance between the frontmost mesh and the backmost mesh")]
	private float spread;

	[global::UnityEngine.SerializeField]
	private bool billboard;

	private global::UnityEngine.MaterialPropertyBlock materialPropertyBlock;

	private int internalCount;

	private float randomStatic;

	private global::UnityEngine.Collider boundaryCollider;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private static bool IsVisible(global::UnityEngine.Camera camera, global::UnityEngine.Bounds bounds)
	{
		return false;
	}

	private void RenderFlames(global::UnityEngine.Rendering.ScriptableRenderContext context, global::UnityEngine.Camera camera)
	{
	}

	private void SetupMaterialPropertyBlock(float item)
	{
	}

	private void CreateItem(float spacing, float item, global::UnityEngine.Camera camera)
	{
	}
}
