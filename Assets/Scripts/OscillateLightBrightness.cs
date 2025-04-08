public class OscillateLightBrightness : global::UnityEngine.MonoBehaviour
{
	private global::UnityEngine.Light lightComponent;

	[global::UnityEngine.SerializeField]
	[global::UnityEngine.Range(0f, 10f)]
	private float lower;

	[global::UnityEngine.SerializeField]
	[global::UnityEngine.Range(0f, 10f)]
	private float upper;

	private void Start()
	{
	}

	private void Update()
	{
	}
}
