using System;
using System.Collections.Generic;
using UnityEngine;

namespace Ardenfall.Utilities
{
	[Serializable]
	public class MaterialOverrides
	{
		[Serializable]
		public class TextureProperty
		{
			public string propertyName;

			public Texture2D propertyValue;
		}

		[Serializable]
		public class FloatProperty
		{
			public string propertyName;

			public float propertyValue;
		}

		[Serializable]
		public class IntProperty
		{
			public string propertyName;

			public int propertyValue;
		}

		[Serializable]
		public class VectorProperty
		{
			public string propertyName;

			public Vector4 propertyValue;
		}

		[Serializable]
		public class ColorProperty
		{
			public string propertyName;

			public Color propertyValue;
		}

		public List<TextureProperty> textureOverrides;

		public List<FloatProperty> floatOverrides;

		public List<IntProperty> intOverrides;

		public List<VectorProperty> vectorOverrides;

		public List<ColorProperty> colorOverrides;

		public void OverrideMaterial(Material material)
		{
		}
	}
}
