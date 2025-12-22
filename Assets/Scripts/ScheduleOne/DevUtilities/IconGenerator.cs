namespace ScheduleOne.DevUtilities
{
	public class IconGenerator : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.DevUtilities.IconGenerator>
	{
		[global::System.Serializable]
		public class PackagingVisuals
		{
			public string PackagingID;

			public global::ScheduleOne.Product.MultiTypeVisualsSetter ProductVisuals;

			public global::UnityEngine.Transform TopLevelTransform;
		}

		public int IconSize;

		public string OutputPath;

		public bool ModifyLighting;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.Registry Registry;

		public global::UnityEngine.Camera CameraPosition;

		public global::UnityEngine.Transform MainContainer;

		public global::UnityEngine.Transform ItemContainer;

		public global::UnityEngine.GameObject Canvas;

		public global::System.Collections.Generic.List<global::ScheduleOne.DevUtilities.IconGenerator.PackagingVisuals> Visuals;

		public global::UnityEngine.Rendering.Universal.UniversalRendererData rendererData;

		protected override void Awake()
		{
		}

		[global::EasyButtons.Button]
		public void GenerateIcon()
		{
		}

		public global::UnityEngine.Texture2D GeneratePackagingIcon(string packagingID, string productID)
		{
			return null;
		}

		public global::UnityEngine.Texture2D GetTexture(global::UnityEngine.Transform model)
		{
			return null;
		}
	}
}
