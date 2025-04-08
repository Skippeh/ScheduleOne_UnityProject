namespace Ardenfall.Utilities
{
	[global::System.Serializable]
	public class MaterialOverrides
	{
		[global::System.Serializable]
		public class TextureProperty
		{
			public string propertyName;

			public global::UnityEngine.Texture2D propertyValue;
		}

		[global::System.Serializable]
		public class FloatProperty
		{
			public string propertyName;

			public float propertyValue;
		}

		[global::System.Serializable]
		public class IntProperty
		{
			public string propertyName;

			public int propertyValue;
		}

		[global::System.Serializable]
		public class VectorProperty
		{
			public string propertyName;

			public global::UnityEngine.Vector4 propertyValue;
		}

		[global::System.Serializable]
		public class ColorProperty
		{
			public string propertyName;

			public global::UnityEngine.Color propertyValue;
		}

		public global::System.Collections.Generic.List<global::Ardenfall.Utilities.MaterialOverrides.TextureProperty> textureOverrides;

		public global::System.Collections.Generic.List<global::Ardenfall.Utilities.MaterialOverrides.FloatProperty> floatOverrides;

		public global::System.Collections.Generic.List<global::Ardenfall.Utilities.MaterialOverrides.IntProperty> intOverrides;

		public global::System.Collections.Generic.List<global::Ardenfall.Utilities.MaterialOverrides.VectorProperty> vectorOverrides;

		public global::System.Collections.Generic.List<global::Ardenfall.Utilities.MaterialOverrides.ColorProperty> colorOverrides;

		public void OverrideMaterial(global::UnityEngine.Material material)
		{
		}
	}
}
