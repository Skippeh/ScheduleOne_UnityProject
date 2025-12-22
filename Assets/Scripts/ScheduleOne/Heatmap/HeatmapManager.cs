namespace ScheduleOne.Heatmap
{
	public class HeatmapManager : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.Heatmap.HeatmapManager>
	{
		[global::System.Serializable]
		public class PropertyData
		{
			public int[] MaskData;

			public global::UnityEngine.Matrix4x4[] Matrices;

			public global::System.Collections.Generic.List<global::ScheduleOne.Heatmap.HeatmapRegion> Regions;

			public global::ScheduleOne.Property.Property Property;

			public bool InitialDispatched;
		}

		private struct PropertyRegionReference
		{
			public string PropertyCode;

			public int RegionAmount;
		}

		public global::System.Action<global::ScheduleOne.Property.Property, bool> onHeatmapVisibilityChanged;

		[global::UnityEngine.Header("Components")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.ComputeShader _shader;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.RenderTexture _heatmaps;

		[global::UnityEngine.SerializeField]
		private global::ScheduleOne.Heatmap.HeatmapRegion _heatmapRegionPrefab;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Material _heatmapMat;

		[global::UnityEngine.Header("Settings")]
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Texture2D _gradientTexture;

		[global::UnityEngine.Header("Debugging & Testing")]
		[global::UnityEngine.SerializeField]
		private string _propertyCodeToTest;

		private global::System.Collections.Generic.Dictionary<string, global::ScheduleOne.Heatmap.HeatmapManager.PropertyData> _propertyGridMasks;

		private global::System.Collections.Generic.List<global::ScheduleOne.Heatmap.HeatmapManager.PropertyRegionReference> _propertyRegionReferences;

		private int _kernal;

		private int _textureDepth;

		public const int TEXTURE_SIZE = 128;

		public const int MAX_REGIONS = 16;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Initialise()
		{
		}

		private void SetShader()
		{
		}

		private void SetPropertyData()
		{
		}

		private void OnEmitterUpdate(string propertyCode, global::ScheduleOne.Temperature.TemperatureEmitterInfo[] emitterInfos)
		{
		}

		private void DispatchHeatmap(string propertyCode, global::ScheduleOne.Temperature.TemperatureEmitterInfo[] emitterInfos)
		{
		}

		private global::UnityEngine.Vector2Int GetPropertyRegionStartAndEndIndex(string propertyCode)
		{
			return default(global::UnityEngine.Vector2Int);
		}

		public void SetHeatmapActive(string propertyCode, bool isActive)
		{
		}

		public void SetHeatmapActive(global::ScheduleOne.Property.Property property, bool isActive)
		{
		}

		public void ToggleHeatmapActive(global::ScheduleOne.Property.Property property)
		{
		}

		public void SetAllHeatmapsActive(bool isActive)
		{
		}

		public bool IsHeatmapActive(global::ScheduleOne.Property.Property property)
		{
			return false;
		}

		protected override void OnDestroy()
		{
		}

		[global::EasyButtons.Button]
		public void TurnOnAllHeatmaps()
		{
		}

		[global::EasyButtons.Button]
		public void TurnOffAllHeatmaps()
		{
		}

		[global::EasyButtons.Button]
		public void RunDispatchHeatmap()
		{
		}
	}
}
