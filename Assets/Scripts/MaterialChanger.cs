[global::UnityEngine.ExecuteAlways]
public class MaterialChanger : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.SerializeField]
	[global::UnityEngine.Range(0f, 5f)]
	private float _value;

	[global::UnityEngine.SerializeField]
	private string _changeMaterialSetting;

	private global::UnityEngine.Renderer[] _renderers;

	private global::UnityEngine.MaterialPropertyBlock _propBlock;

	private void OnEnable()
	{
	}

	private void Update()
	{
	}

	private void FindAllMaterialInChild()
	{
	}

	private void SetNewValueForAllMaterial(float value)
	{
	}
}
