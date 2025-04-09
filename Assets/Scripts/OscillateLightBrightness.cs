using UnityEngine;

public class OscillateLightBrightness : MonoBehaviour
{
	private Light lightComponent;

	[SerializeField]
	[Range(0f, 10f)]
	private float lower;

	[SerializeField]
	[Range(0f, 10f)]
	private float upper;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
