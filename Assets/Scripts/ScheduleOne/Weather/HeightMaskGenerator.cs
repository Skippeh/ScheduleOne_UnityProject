namespace ScheduleOne.Weather
{
	public class HeightMaskGenerator : global::UnityEngine.MonoBehaviour
	{
		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.ComputeShader _maskShader;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private float _size;

		[global::UnityEngine.SerializeField]
		private int _resolution;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector2 _minMaxHeight;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.LayerMask _heightmapLayerMask;

		[global::UnityEngine.Header("Debugging & Development")]
		[global::UnityEngine.SerializeField]
		private float _debugTileSize;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.RenderTexture _heightTexture;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Material _debugMaterial;

		private int _kernal;

		private float _tileSize;

		private float _tileHalfSize;

		private global::UnityEngine.Vector3 _origin;

		private global::UnityEngine.ComputeBuffer _heightBuffer;

		public void InitialiseMaskMap()
		{
		}

		private void GenerateMaskMap()
		{
		}

		private void OnDestroy()
		{
		}

		[global::ScheduleOne.Core.Button]
		private void GenerateHeightMapDebug()
		{
		}

		[global::ScheduleOne.Core.Button]
		private void Dispose()
		{
		}

		private void OnDrawGizmos()
		{
		}
	}
}
