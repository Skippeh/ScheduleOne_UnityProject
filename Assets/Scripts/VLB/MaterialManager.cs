using System.Collections;
using UnityEngine;
using UnityEngine.Rendering;

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

			void ApplyToMaterial(Material mat);

			ShaderMode GetShaderMode();
		}

		public struct StaticPropertiesSD : IStaticProperties
		{
			public BlendingMode blendingMode;

			public Noise3D noise3D;

			public SD.DepthBlend depthBlend;

			public ColorGradient colorGradient;

			public SD.DynamicOcclusion dynamicOcclusion;

			public SD.MeshSkewing meshSkewing;

			public SD.ShaderAccuracy shaderAccuracy;

			public static int staticPropertiesCount => 0;

			private int blendingModeID => 0;

			private int noise3DID => 0;

			private int depthBlendID => 0;

			private int colorGradientID => 0;

			private int dynamicOcclusionID => 0;

			private int meshSkewingID => 0;

			private int shaderAccuracyID => 0;

			public ShaderMode GetShaderMode()
			{
				return default(ShaderMode);
			}

			public int GetPropertiesCount()
			{
				return 0;
			}

			public int GetMaterialID()
			{
				return 0;
			}

			public void ApplyToMaterial(Material mat)
			{
			}
		}

		public struct StaticPropertiesHD : IStaticProperties
		{
			public BlendingMode blendingMode;

			public HD.Attenuation attenuation;

			public Noise3D noise3D;

			public ColorGradient colorGradient;

			public HD.Shadow shadow;

			public HD.Cookie cookie;

			public int raymarchingQualityIndex;

			public static int staticPropertiesCount => 0;

			private int blendingModeID => 0;

			private int attenuationID => 0;

			private int noise3DID => 0;

			private int colorGradientID => 0;

			private int dynamicOcclusionID => 0;

			private int cookieID => 0;

			private int raymarchingQualityID => 0;

			public ShaderMode GetShaderMode()
			{
				return default(ShaderMode);
			}

			public int GetPropertiesCount()
			{
				return 0;
			}

			public int GetMaterialID()
			{
				return 0;
			}

			public void ApplyToMaterial(Material mat)
			{
			}
		}

		private class MaterialsGroup
		{
			public Material[] materials;

			public MaterialsGroup(int count)
			{
			}
		}

		private enum ZWrite
		{
			Off = 0,
			On = 1
		}

		public static MaterialPropertyBlock materialPropertyBlock;

		private static readonly BlendMode[] BlendingMode_SrcFactor;

		private static readonly BlendMode[] BlendingMode_DstFactor;

		private static readonly bool[] BlendingMode_AlphaAsBlack;

		private static Hashtable ms_MaterialsGroupSD;

		private static Hashtable ms_MaterialsGroupHD;

		public static Material NewMaterialPersistent(Shader shader, bool gpuInstanced)
		{
			return null;
		}

		public static Material GetInstancedMaterial(uint groupID, ref StaticPropertiesSD staticProps)
		{
			return null;
		}

		public static Material GetInstancedMaterial(uint groupID, ref StaticPropertiesHD staticProps)
		{
			return null;
		}

		private static Material GetInstancedMaterial(Hashtable groups, uint groupID, ref IStaticProperties staticProps)
		{
			return null;
		}

		private static void SetBlendingMode(this Material mat, int nameID, BlendMode value)
		{
		}

		private static void SetStencilRef(this Material mat, int nameID, int value)
		{
		}

		private static void SetStencilComp(this Material mat, int nameID, CompareFunction value)
		{
		}

		private static void SetStencilOp(this Material mat, int nameID, StencilOp value)
		{
		}

		private static void SetCull(this Material mat, int nameID, CullMode value)
		{
		}

		private static void SetZWrite(this Material mat, int nameID, ZWrite value)
		{
		}

		private static void SetZTest(this Material mat, int nameID, CompareFunction value)
		{
		}
	}
}
