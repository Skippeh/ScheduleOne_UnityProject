using UnityEngine;

[ExecuteAlways]
public class MaterialChanger : MonoBehaviour
{
	[SerializeField]
	[Range(0f, 5f)]
	private float _value;

	[SerializeField]
	private string _changeMaterialSetting;

	private Renderer[] _renderers;

	private MaterialPropertyBlock _propBlock;

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
