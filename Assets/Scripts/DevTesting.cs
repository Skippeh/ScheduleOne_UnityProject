public class DevTesting : global::UnityEngine.MonoBehaviour
{
	[global::System.Serializable]
	public class WeatherVolumeData
	{
		public global::UnityEngine.Transform Origin;

		public float Wetness;
	}

	[global::UnityEngine.Header("Components")]
	[global::UnityEngine.SerializeField]
	private global::UnityEngine.ComputeShader _wetMaskShader;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Transform mapOrigin;

	[global::UnityEngine.SerializeField]
	private global::System.Collections.Generic.List<DevTesting.WeatherVolumeData> _weatherVolumes;

	[global::UnityEngine.Header("Settings")]
	[global::UnityEngine.SerializeField]
	private int _resolution;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Vector3 mapSize;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.Vector3 boxSize;

	[global::UnityEngine.SerializeField]
	[global::UnityEngine.Range(0f, 1f)]
	private float _blend;

	[global::UnityEngine.SerializeField]
	private float _updateTime;

	[global::UnityEngine.SerializeField]
	private bool _updateWetMask;

	[global::UnityEngine.SerializeField]
	private global::UnityEngine.RenderTexture _wetMaskTexture;

	private global::UnityEngine.Vector3 _velocity;

	private void Start()
	{
	}

	[global::ScheduleOne.Core.Button]
	private void DebugRunShader()
	{
	}

	[global::ScheduleOne.Core.Button]
	private void ClearShader()
	{
	}

	private void SetupShader()
	{
	}

	private void RunShader()
	{
	}

	private void Update()
	{
	}

	private void OnDrawGizmos()
	{
	}

	private void OnDestroy()
	{
	}
}
