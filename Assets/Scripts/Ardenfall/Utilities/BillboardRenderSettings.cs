using System;
using System.Collections.Generic;
using UnityEngine;

namespace Ardenfall.Utilities
{
	[CreateAssetMenu(menuName = "Ardenfall/Foliage/Billboard Render Settings")]
	public class BillboardRenderSettings : ScriptableObject
	{
		[Serializable]
		public class BillboardTexture
		{
			public string textureId;

			public bool powerOfTwo;

			public bool alphaIsTransparency;

			public List<BakePass> bakePasses;

			public TextureFormat GetFormat()
			{
				return default(TextureFormat);
			}
		}

		[Serializable]
		public class BakePass
		{
			public Shader customShader;

			public MaterialOverrides materialOverrides;

			public bool r;

			public bool g;

			public bool b;

			public bool a;
		}

		public List<BillboardTexture> billboardTextures;

		public Shader billboardShader;
	}
}
