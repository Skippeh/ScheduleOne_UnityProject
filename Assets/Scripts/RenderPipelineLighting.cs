[global::UnityEngine.ExecuteInEditMode]
public class RenderPipelineLighting : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.SerializeField]
	private global::UnityEngine.GameObject _standardLighting;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Material _standardSky;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Material _standardTerrain;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.GameObject _universalLighting;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Material _universalSky;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Material _universalTerrain;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.GameObject _highDefinitionLighting;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Material _highDefinitionSky;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Material _highDefinitionTerrain;

	private void OnValidate()
	{
	}

	private void Awake()
	{
	}
}
