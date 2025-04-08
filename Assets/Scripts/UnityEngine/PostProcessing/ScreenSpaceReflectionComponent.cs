namespace UnityEngine.PostProcessing
{
	public sealed class ScreenSpaceReflectionComponent : global::UnityEngine.PostProcessing.PostProcessingComponentCommandBuffer<global::UnityEngine.PostProcessing.ScreenSpaceReflectionModel>
	{
		private static class Uniforms
		{
			internal static readonly int _RayStepSize;

			internal static readonly int _AdditiveReflection;

			internal static readonly int _BilateralUpsampling;

			internal static readonly int _TreatBackfaceHitAsMiss;

			internal static readonly int _AllowBackwardsRays;

			internal static readonly int _TraceBehindObjects;

			internal static readonly int _MaxSteps;

			internal static readonly int _FullResolutionFiltering;

			internal static readonly int _HalfResolution;

			internal static readonly int _HighlightSuppression;

			internal static readonly int _PixelsPerMeterAtOneMeter;

			internal static readonly int _ScreenEdgeFading;

			internal static readonly int _ReflectionBlur;

			internal static readonly int _MaxRayTraceDistance;

			internal static readonly int _FadeDistance;

			internal static readonly int _LayerThickness;

			internal static readonly int _SSRMultiplier;

			internal static readonly int _FresnelFade;

			internal static readonly int _FresnelFadePower;

			internal static readonly int _ReflectionBufferSize;

			internal static readonly int _ScreenSize;

			internal static readonly int _InvScreenSize;

			internal static readonly int _ProjInfo;

			internal static readonly int _CameraClipInfo;

			internal static readonly int _ProjectToPixelMatrix;

			internal static readonly int _WorldToCameraMatrix;

			internal static readonly int _CameraToWorldMatrix;

			internal static readonly int _Axis;

			internal static readonly int _CurrentMipLevel;

			internal static readonly int _NormalAndRoughnessTexture;

			internal static readonly int _HitPointTexture;

			internal static readonly int _BlurTexture;

			internal static readonly int _FilteredReflections;

			internal static readonly int _FinalReflectionTexture;

			internal static readonly int _TempTexture;
		}

		private enum PassIndex
		{
			RayTraceStep = 0,
			CompositeFinal = 1,
			Blur = 2,
			CompositeSSR = 3,
			MinMipGeneration = 4,
			HitPointToReflections = 5,
			BilateralKeyPack = 6,
			BlitDepthAsCSZ = 7,
			PoissonBlur = 8
		}

		private bool k_HighlightSuppression;

		private bool k_TraceBehindObjects;

		private bool k_TreatBackfaceHitAsMiss;

		private bool k_BilateralUpsample;

		private readonly int[] m_ReflectionTextures;

		public override bool active => false;

		public override global::UnityEngine.DepthTextureMode GetCameraFlags()
		{
			return default(global::UnityEngine.DepthTextureMode);
		}

		public override void OnEnable()
		{
		}

		public override string GetName()
		{
			return null;
		}

		public override global::UnityEngine.Rendering.CameraEvent GetCameraEvent()
		{
			return default(global::UnityEngine.Rendering.CameraEvent);
		}

		public override void PopulateCommandBuffer(global::UnityEngine.Rendering.CommandBuffer cb)
		{
		}
	}
}
