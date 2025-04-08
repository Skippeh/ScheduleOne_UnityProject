namespace VLB
{
	public static class Consts
	{
		public static class Help
		{
			public static class SD
			{
				public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam-sd/";

				public const string UrlDynamicOcclusionRaycasting = "http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-raycasting/";

				public const string UrlDynamicOcclusionDepthBuffer = "http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-depthbuffer/";

				public const string UrlSkewingHandle = "http://saladgamer.com/vlb-doc/comp-skewinghandle-sd/";
			}

			public static class HD
			{
				public const string UrlBeam = "http://saladgamer.com/vlb-doc/comp-lightbeam-hd/";

				public const string UrlShadow = "http://saladgamer.com/vlb-doc/comp-shadow-hd/";

				public const string UrlCookie = "http://saladgamer.com/vlb-doc/comp-cookie-hd/";

				public const string UrlTrackRealtimeChangesOnLight = "http://saladgamer.com/vlb-doc/comp-trackrealtimechanges-hd/";
			}

			private const string UrlBase = "http://saladgamer.com/vlb-doc/";

			private const string UrlSuffix = "/";

			public const string UrlDustParticles = "http://saladgamer.com/vlb-doc/comp-dustparticles/";

			public const string UrlTriggerZone = "http://saladgamer.com/vlb-doc/comp-triggerzone/";

			public const string UrlEffectFlicker = "http://saladgamer.com/vlb-doc/comp-effect-flicker/";

			public const string UrlEffectPulse = "http://saladgamer.com/vlb-doc/comp-effect-pulse/";

			public const string UrlEffectFromProfile = "http://saladgamer.com/vlb-doc/comp-effect-from-profile/";

			public const string UrlConfig = "http://saladgamer.com/vlb-doc/config/";
		}

		public static class Internal
		{
			public static readonly bool ProceduralObjectsVisibleInEditor;

			public static global::UnityEngine.HideFlags ProceduralObjectsHideFlags => default(global::UnityEngine.HideFlags);
		}

		public static class Beam
		{
			public static class SD
			{
				public const float FresnelPowMaxValue = 10f;

				public const float FresnelPow = 8f;

				public const float GlareFrontalDefault = 0.5f;

				public const float GlareBehindDefault = 0.5f;

				public const float GlareMin = 0f;

				public const float GlareMax = 1f;

				public static readonly global::UnityEngine.Vector2 TiltDefault;

				public static readonly global::UnityEngine.Vector3 SkewingLocalForwardDirectionDefault;

				public const global::UnityEngine.Transform ClippingPlaneTransformDefault = null;
			}

			public static class HD
			{
				public const global::VLB.AttenuationEquationHD AttenuationEquationDefault = global::VLB.AttenuationEquationHD.Quadratic;

				public const float SideSoftnessDefault = 1f;

				public const float SideSoftnessMin = 0.0001f;

				public const float SideSoftnessMax = 10f;

				public const float JitteringFactorDefault = 0f;

				public const float JitteringFactorMin = 0f;

				public const int JitteringFrameRateDefault = 60;

				public const int JitteringFrameRateMin = 0;

				public const int JitteringFrameRateMax = 120;

				public static readonly global::VLB.MinMaxRangeFloat JitteringLerpRange;
			}

			public static readonly global::UnityEngine.Color FlatColor;

			public const global::VLB.ColorMode ColorModeDefault = global::VLB.ColorMode.Flat;

			public const float MultiplierDefault = 1f;

			public const float MultiplierMin = 0f;

			public const float IntensityDefault = 1f;

			public const float IntensityMin = 0f;

			public const float HDRPExposureWeightDefault = 0f;

			public const float HDRPExposureWeightMin = 0f;

			public const float HDRPExposureWeightMax = 1f;

			public const float SpotAngleDefault = 35f;

			public const float SpotAngleMin = 0.1f;

			public const float SpotAngleMax = 179.9f;

			public const float ConeRadiusStart = 0.1f;

			public const global::VLB.MeshType GeomMeshType = global::VLB.MeshType.Shared;

			public const int GeomSidesDefault = 18;

			public const int GeomSidesMin = 3;

			public const int GeomSidesMax = 256;

			public const int GeomSegmentsDefault = 5;

			public const int GeomSegmentsMin = 0;

			public const int GeomSegmentsMax = 64;

			public const bool GeomCap = false;

			public const bool ScalableDefault = true;

			public const global::VLB.AttenuationEquation AttenuationEquationDefault = global::VLB.AttenuationEquation.Quadratic;

			public const float AttenuationCustomBlendingDefault = 0.5f;

			public const float AttenuationCustomBlendingMin = 0f;

			public const float AttenuationCustomBlendingMax = 1f;

			public const float FallOffStart = 0f;

			public const float FallOffEnd = 3f;

			public const float FallOffDistancesMinThreshold = 0.01f;

			public const float DepthBlendDistance = 2f;

			public const float CameraClippingDistance = 0.5f;

			public const global::VLB.NoiseMode NoiseModeDefault = global::VLB.NoiseMode.Disabled;

			public const float NoiseIntensityMin = 0f;

			public const float NoiseIntensityMax = 1f;

			public const float NoiseIntensityDefault = 0.5f;

			public const float NoiseScaleMin = 0.01f;

			public const float NoiseScaleMax = 2f;

			public const float NoiseScaleDefault = 0.5f;

			public static readonly global::UnityEngine.Vector3 NoiseVelocityDefault;

			public const global::VLB.BlendingMode BlendingModeDefault = global::VLB.BlendingMode.Additive;

			public const global::VLB.ShaderAccuracy ShaderAccuracyDefault = global::VLB.ShaderAccuracy.Fast;

			public const float FadeOutBeginDefault = -150f;

			public const float FadeOutEndDefault = -200f;

			public const global::VLB.Dimensions DimensionsDefault = global::VLB.Dimensions.Dim3D;
		}

		public static class DustParticles
		{
			public const float AlphaDefault = 0.5f;

			public const float SizeDefault = 0.01f;

			public const global::VLB.ParticlesDirection DirectionDefault = global::VLB.ParticlesDirection.Random;

			public static readonly global::UnityEngine.Vector3 VelocityDefault;

			public const float DensityDefault = 5f;

			public const float DensityMin = 0f;

			public const float DensityMax = 1000f;

			public static readonly global::VLB.MinMaxRangeFloat SpawnDistanceRangeDefault;

			public const bool CullingEnabledDefault = false;

			public const float CullingMaxDistanceDefault = 10f;

			public const float CullingMaxDistanceMin = 1f;
		}

		public static class DynOcclusion
		{
			public static readonly global::UnityEngine.LayerMask LayerMaskDefault;

			public const global::VLB.DynamicOcclusionUpdateRate UpdateRateDefault = global::VLB.DynamicOcclusionUpdateRate.EveryXFrames;

			public const int WaitFramesCountDefault = 3;

			public const global::VLB.Dimensions RaycastingDimensionsDefault = global::VLB.Dimensions.Dim3D;

			public const bool RaycastingConsiderTriggersDefault = false;

			public const float RaycastingMinOccluderAreaDefault = 0f;

			public const float RaycastingMinSurfaceRatioDefault = 0.5f;

			public const float RaycastingMinSurfaceRatioMin = 50f;

			public const float RaycastingMinSurfaceRatioMax = 100f;

			public const float RaycastingMaxSurfaceDotDefault = 0.25f;

			public const float RaycastingMaxSurfaceAngleMin = 45f;

			public const float RaycastingMaxSurfaceAngleMax = 90f;

			public const global::VLB.PlaneAlignment RaycastingPlaneAlignmentDefault = global::VLB.PlaneAlignment.Surface;

			public const float RaycastingPlaneOffsetDefault = 0.1f;

			public const float RaycastingFadeDistanceToSurfaceDefault = 0.25f;

			public const int DepthBufferDepthMapResolutionDefault = 128;

			public const bool DepthBufferOcclusionCullingDefault = true;

			public const float DepthBufferFadeDistanceToSurfaceDefault = 0f;
		}

		public static class Effects
		{
			public const global::VLB.EffectAbstractBase.ComponentsToChange ComponentsToChangeDefault = (global::VLB.EffectAbstractBase.ComponentsToChange)2147483647;

			public const bool RestoreIntensityOnDisableDefault = true;

			public const float FrequencyDefault = 10f;

			public const bool PerformPausesDefault = false;

			public const bool RestoreIntensityOnPauseDefault = false;

			public static readonly global::VLB.MinMaxRangeFloat FlickeringDurationDefault;

			public static readonly global::VLB.MinMaxRangeFloat PauseDurationDefault;

			public static readonly global::VLB.MinMaxRangeFloat IntensityAmplitudeDefault;

			public const float SmoothingDefault = 0.05f;
		}

		public static class Shadow
		{
			public const float StrengthDefault = 1f;

			public const float StrengthMin = 0f;

			public const float StrengthMax = 1f;

			public static readonly global::UnityEngine.LayerMask LayerMaskDefault;

			public const global::VLB.ShadowUpdateRate UpdateRateDefault = global::VLB.ShadowUpdateRate.EveryXFrames;

			public const int WaitFramesCountDefault = 3;

			public const int DepthMapResolutionDefault = 128;

			public const bool OcclusionCullingDefault = true;

			public static string GetErrorChangeRuntimeDepthMapResolution(global::VLB.VolumetricShadowHD comp)
			{
				return null;
			}
		}

		public static class Cookie
		{
			public const float ContributionDefault = 1f;

			public const float ContributionMin = 0f;

			public const float ContributionMax = 1f;

			public const global::UnityEngine.Texture CookieTextureDefault = null;

			public const global::VLB.CookieChannel ChannelDefault = global::VLB.CookieChannel.Alpha;

			public const bool NegativeDefault = false;

			public static readonly global::UnityEngine.Vector2 TranslationDefault;

			public const float RotationDefault = 0f;

			public static readonly global::UnityEngine.Vector2 ScaleDefault;
		}

		public static class Config
		{
			public static class HD
			{
				public const global::VLB.RenderQueue GeometryRenderQueueDefault = (global::VLB.RenderQueue)3100;

				public const float CameraBlendingDistance = 0.5f;

				public const int RaymarchingQualitiesStepsMin = 2;
			}

			public const bool GeometryOverrideLayerDefault = true;

			public const int GeometryLayerIDDefault = 1;

			public const string GeometryTagDefault = "Untagged";

			public const string FadeOutCameraTagDefault = "MainCamera";

			public const global::VLB.RenderQueue GeometryRenderQueueDefault = global::VLB.RenderQueue.Transparent;

			public const global::VLB.RenderPipeline GeometryRenderPipelineDefault = global::VLB.RenderPipeline.BuiltIn;

			public const global::VLB.RenderingMode GeometryRenderingModeDefault = global::VLB.RenderingMode.Default;

			public const int Noise3DSizeDefault = 64;

			public const float DitheringFactor = 0f;

			public const bool UseLightColorTemperatureDefault = true;

			public const bool FeatureEnabledDefault = true;

			public const global::VLB.FeatureEnabledColorGradient FeatureEnabledColorGradientDefault = global::VLB.FeatureEnabledColorGradient.HighOnly;

			public const int SharedMeshSidesDefault = 24;

			public const int SharedMeshSidesMin = 3;

			public const int SharedMeshSidesMax = 256;

			public const int SharedMeshSegmentsDefault = 5;

			public const int SharedMeshSegmentsMin = 0;

			public const int SharedMeshSegmentsMax = 64;
		}

		public const string PluginFolder = "VolumetricLightBeam";
	}
}
