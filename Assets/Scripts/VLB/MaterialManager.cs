namespace VLB
{
	public static class MaterialManager
	{
		public enum BlendingMode
		{
			Additive = 0,
			SoftAdditive = 1,
			TraditionalTransparency = 2,
			Count = 3
		}

		public enum ColorGradient
		{
			Off = 0,
			MatrixLow = 1,
			MatrixHigh = 2,
			Count = 3
		}

		public enum Noise3D
		{
			Off = 0,
			On = 1,
			Count = 2
		}

		public static class SD
		{
			public enum DepthBlend
			{
				Off = 0,
				On = 1,
				Count = 2
			}

			public enum DynamicOcclusion
			{
				Off = 0,
				ClippingPlane = 1,
				DepthTexture = 2,
				Count = 3
			}

			public enum MeshSkewing
			{
				Off = 0,
				On = 1,
				Count = 2
			}

			public enum ShaderAccuracy
			{
				Fast = 0,
				High = 1,
				Count = 2
			}
		}

		public static class HD
		{
			public enum Attenuation
			{
				Linear = 0,
				Quadratic = 1,
				Count = 2
			}

			public enum Shadow
			{
				Off = 0,
				On = 1,
				Count = 2
			}

			public enum Cookie
			{
				Off = 0,
				SingleChannel = 1,
				RGBA = 2,
				Count = 3
			}
		}

		private interface IStaticProperties
		{
			int GetPropertiesCount();

			int GetMaterialID();

			void ApplyToMaterial(global::UnityEngine.Material mat);

			global::VLB.ShaderMode GetShaderMode();
		}

		public struct StaticPropertiesSD : global::VLB.MaterialManager.IStaticProperties
		{
			public global::VLB.MaterialManager.BlendingMode blendingMode;

			public global::VLB.MaterialManager.Noise3D noise3D;

			public global::VLB.MaterialManager.SD.DepthBlend depthBlend;

			public global::VLB.MaterialManager.ColorGradient colorGradient;

			public global::VLB.MaterialManager.SD.DynamicOcclusion dynamicOcclusion;

			public global::VLB.MaterialManager.SD.MeshSkewing meshSkewing;

			public global::VLB.MaterialManager.SD.ShaderAccuracy shaderAccuracy;

			public static int staticPropertiesCount => 0;

			private int blendingModeID => 0;

			private int noise3DID => 0;

			private int depthBlendID => 0;

			private int colorGradientID => 0;

			private int dynamicOcclusionID => 0;

			private int meshSkewingID => 0;

			private int shaderAccuracyID => 0;

			public global::VLB.ShaderMode GetShaderMode()
			{
				return default(global::VLB.ShaderMode);
			}

			public int GetPropertiesCount()
			{
				return 0;
			}

			public int GetMaterialID()
			{
				return 0;
			}

			public void ApplyToMaterial(global::UnityEngine.Material mat)
			{
			}
		}

		public struct StaticPropertiesHD : global::VLB.MaterialManager.IStaticProperties
		{
			public global::VLB.MaterialManager.BlendingMode blendingMode;

			public global::VLB.MaterialManager.HD.Attenuation attenuation;

			public global::VLB.MaterialManager.Noise3D noise3D;

			public global::VLB.MaterialManager.ColorGradient colorGradient;

			public global::VLB.MaterialManager.HD.Shadow shadow;

			public global::VLB.MaterialManager.HD.Cookie cookie;

			public int raymarchingQualityIndex;

			public static int staticPropertiesCount => 0;

			private int blendingModeID => 0;

			private int attenuationID => 0;

			private int noise3DID => 0;

			private int colorGradientID => 0;

			private int dynamicOcclusionID => 0;

			private int cookieID => 0;

			private int raymarchingQualityID => 0;

			public global::VLB.ShaderMode GetShaderMode()
			{
				return default(global::VLB.ShaderMode);
			}

			public int GetPropertiesCount()
			{
				return 0;
			}

			public int GetMaterialID()
			{
				return 0;
			}

			public void ApplyToMaterial(global::UnityEngine.Material mat)
			{
			}
		}

		private class MaterialsGroup
		{
			public global::UnityEngine.Material[] materials;

			public MaterialsGroup(int count)
			{
			}
		}

		private enum ZWrite
		{
			Off = 0,
			On = 1
		}

		public static global::UnityEngine.MaterialPropertyBlock materialPropertyBlock;

		private static readonly global::UnityEngine.Rendering.BlendMode[] BlendingMode_SrcFactor;

		private static readonly global::UnityEngine.Rendering.BlendMode[] BlendingMode_DstFactor;

		private static readonly bool[] BlendingMode_AlphaAsBlack;

		private static global::System.Collections.Hashtable ms_MaterialsGroupSD;

		private static global::System.Collections.Hashtable ms_MaterialsGroupHD;

		public static global::UnityEngine.Material NewMaterialPersistent(global::UnityEngine.Shader shader, bool gpuInstanced)
		{
			return null;
		}

		public static global::UnityEngine.Material GetInstancedMaterial(uint groupID, ref global::VLB.MaterialManager.StaticPropertiesSD staticProps)
		{
			return null;
		}

		public static global::UnityEngine.Material GetInstancedMaterial(uint groupID, ref global::VLB.MaterialManager.StaticPropertiesHD staticProps)
		{
			return null;
		}

		private static global::UnityEngine.Material GetInstancedMaterial(global::System.Collections.Hashtable groups, uint groupID, ref global::VLB.MaterialManager.IStaticProperties staticProps)
		{
			return null;
		}

		private static void SetBlendingMode(this global::UnityEngine.Material mat, int nameID, global::UnityEngine.Rendering.BlendMode value)
		{
		}

		private static void SetStencilRef(this global::UnityEngine.Material mat, int nameID, int value)
		{
		}

		private static void SetStencilComp(this global::UnityEngine.Material mat, int nameID, global::UnityEngine.Rendering.CompareFunction value)
		{
		}

		private static void SetStencilOp(this global::UnityEngine.Material mat, int nameID, global::UnityEngine.Rendering.StencilOp value)
		{
		}

		private static void SetCull(this global::UnityEngine.Material mat, int nameID, global::UnityEngine.Rendering.CullMode value)
		{
		}

		private static void SetZWrite(this global::UnityEngine.Material mat, int nameID, global::VLB.MaterialManager.ZWrite value)
		{
		}

		private static void SetZTest(this global::UnityEngine.Material mat, int nameID, global::UnityEngine.Rendering.CompareFunction value)
		{
		}
	}
}
