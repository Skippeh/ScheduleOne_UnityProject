namespace Ardenfall.Utilities
{
	[global::UnityEngine.CreateAssetMenu(menuName = "Ardenfall/Foliage/Billboard Render Settings")]
	public class BillboardRenderSettings : global::UnityEngine.ScriptableObject
	{
		[global::System.Serializable]
		public class BillboardTexture
		{
			public string textureId;

			public bool powerOfTwo;

			public bool alphaIsTransparency;

			public global::System.Collections.Generic.List<global::Ardenfall.Utilities.BillboardRenderSettings.BakePass> bakePasses;

			public global::UnityEngine.TextureFormat GetFormat()
			{
				return default(global::UnityEngine.TextureFormat);
			}
		}

		[global::System.Serializable]
		public class BakePass
		{
			public global::UnityEngine.Shader customShader;

			public global::Ardenfall.Utilities.MaterialOverrides materialOverrides;

			public bool r;

			public bool g;

			public bool b;

			public bool a;
		}

		public global::System.Collections.Generic.List<global::Ardenfall.Utilities.BillboardRenderSettings.BillboardTexture> billboardTextures;

		public global::UnityEngine.Shader billboardShader;
	}
}
