namespace UnityEngine.PostProcessing
{
	[global::System.Serializable]
	public class ScreenSpaceReflectionModel : global::UnityEngine.PostProcessing.PostProcessingModel
	{
		public enum SSRResolution
		{
			High = 0,
			Low = 2
		}

		public enum SSRReflectionBlendType
		{
			PhysicallyBased = 0,
			Additive = 1
		}

		[global::System.Serializable]
		public struct IntensitySettings
		{
			[global::UnityEngine.Tooltip("Nonphysical multiplier for the SSR reflections. 1.0 is physically based.")]
			[global::UnityEngine.Range(0f, 2f)]
			public float reflectionMultiplier;

			[global::UnityEngine.Tooltip("How far away from the maxDistance to begin fading SSR.")]
			[global::UnityEngine.Range(0f, 1000f)]
			public float fadeDistance;

			[global::UnityEngine.Tooltip("Amplify Fresnel fade out. Increase if floor reflections look good close to the surface and bad farther 'under' the floor.")]
			[global::UnityEngine.Range(0f, 1f)]
			public float fresnelFade;

			[global::UnityEngine.Tooltip("Higher values correspond to a faster Fresnel fade as the reflection changes from the grazing angle.")]
			[global::UnityEngine.Range(0.1f, 10f)]
			public float fresnelFadePower;
		}

		[global::System.Serializable]
		public struct ReflectionSettings
		{
			[global::UnityEngine.Tooltip("How the reflections are blended into the render.")]
			public global::UnityEngine.PostProcessing.ScreenSpaceReflectionModel.SSRReflectionBlendType blendType;

			[global::UnityEngine.Tooltip("Half resolution SSRR is much faster, but less accurate.")]
			public global::UnityEngine.PostProcessing.ScreenSpaceReflectionModel.SSRResolution reflectionQuality;

			[global::UnityEngine.Tooltip("Maximum reflection distance in world units.")]
			[global::UnityEngine.Range(0.1f, 300f)]
			public float maxDistance;

			[global::UnityEngine.Tooltip("Max raytracing length.")]
			[global::UnityEngine.Range(16f, 1024f)]
			public int iterationCount;

			[global::UnityEngine.Tooltip("Log base 2 of ray tracing coarse step size. Higher traces farther, lower gives better quality silhouettes.")]
			[global::UnityEngine.Range(1f, 16f)]
			public int stepSize;

			[global::UnityEngine.Tooltip("Typical thickness of columns, walls, furniture, and other objects that reflection rays might pass behind.")]
			[global::UnityEngine.Range(0.01f, 10f)]
			public float widthModifier;

			[global::UnityEngine.Tooltip("Blurriness of reflections.")]
			[global::UnityEngine.Range(0.1f, 8f)]
			public float reflectionBlur;

			[global::UnityEngine.Tooltip("Disable for a performance gain in scenes where most glossy objects are horizontal, like floors, water, and tables. Leave on for scenes with glossy vertical objects.")]
			public bool reflectBackfaces;
		}

		[global::System.Serializable]
		public struct ScreenEdgeMask
		{
			[global::UnityEngine.Tooltip("Higher = fade out SSRR near the edge of the screen so that reflections don't pop under camera motion.")]
			[global::UnityEngine.Range(0f, 1f)]
			public float intensity;
		}

		[global::System.Serializable]
		public struct Settings
		{
			public global::UnityEngine.PostProcessing.ScreenSpaceReflectionModel.ReflectionSettings reflection;

			public global::UnityEngine.PostProcessing.ScreenSpaceReflectionModel.IntensitySettings intensity;

			public global::UnityEngine.PostProcessing.ScreenSpaceReflectionModel.ScreenEdgeMask screenEdgeMask;

			public static global::UnityEngine.PostProcessing.ScreenSpaceReflectionModel.Settings defaultSettings => default(global::UnityEngine.PostProcessing.ScreenSpaceReflectionModel.Settings);
		}

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.PostProcessing.ScreenSpaceReflectionModel.Settings m_Settings;

		public global::UnityEngine.PostProcessing.ScreenSpaceReflectionModel.Settings settings
		{
			get
			{
				return default(global::UnityEngine.PostProcessing.ScreenSpaceReflectionModel.Settings);
			}
			set
			{
			}
		}

		public override void Reset()
		{
		}
	}
}
