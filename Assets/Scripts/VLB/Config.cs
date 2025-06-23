namespace VLB
{
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/config/")]
	public class Config : global::UnityEngine.ScriptableObject
	{
		public const string ClassName = "Config";

		public const string kAssetName = "VLBConfigOverride";

		public const string kAssetNameExt = ".asset";

		public bool geometryOverrideLayer;

		public int geometryLayerID;

		public string geometryTag;

		public int geometryRenderQueue;

		public int geometryRenderQueueHD;

		[global::UnityEngine.Serialization.FormerlySerializedAs("renderPipeline")]
		[global::UnityEngine.Serialization.FormerlySerializedAs("_RenderPipeline")]
		[global::UnityEngine.SerializeField]
		private global::VLB.RenderPipeline m_RenderPipeline;

		[global::UnityEngine.Serialization.FormerlySerializedAs("renderingMode")]
		[global::UnityEngine.Serialization.FormerlySerializedAs("_RenderingMode")]
		[global::UnityEngine.SerializeField]
		private global::VLB.RenderingMode m_RenderingMode;

		public float ditheringFactor;

		public bool useLightColorTemperature;

		public int sharedMeshSides;

		public int sharedMeshSegments;

		public float hdBeamsCameraBlendingDistance;

		public int urpDepthCameraScriptableRendererIndex;

		[global::UnityEngine.Range(0.01f, 2f)]
		public float globalNoiseScale;

		public global::UnityEngine.Vector3 globalNoiseVelocity;

		public string fadeOutCameraTag;

		[global::VLB.HighlightNull]
		public global::UnityEngine.Texture3D noiseTexture3D;

		[global::VLB.HighlightNull]
		public global::UnityEngine.ParticleSystem dustParticlesPrefab;

		[global::VLB.HighlightNull]
		public global::UnityEngine.Texture2D ditheringNoiseTexture;

		[global::VLB.HighlightNull]
		public global::UnityEngine.Texture2D jitteringNoiseTexture;

		public global::VLB.FeatureEnabledColorGradient featureEnabledColorGradient;

		public bool featureEnabledDepthBlend;

		public bool featureEnabledNoise3D;

		public bool featureEnabledDynamicOcclusion;

		public bool featureEnabledMeshSkewing;

		public bool featureEnabledShaderAccuracyHigh;

		public bool featureEnabledShadow;

		public bool featureEnabledCookie;

		[global::UnityEngine.SerializeField]
		private global::VLB.RaymarchingQuality[] m_RaymarchingQualities;

		[global::UnityEngine.SerializeField]
		private int m_DefaultRaymarchingQualityUniqueID;

		[global::UnityEngine.SerializeField]
		private int pluginVersion;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Material _DummyMaterial;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Material _DummyMaterialHD;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Shader _BeamShader;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Shader _BeamShaderHD;

		private global::UnityEngine.Transform m_CachedFadeOutCamera;

		private static global::VLB.Config ms_Instance;

		public global::VLB.RenderPipeline renderPipeline
		{
			get
			{
				return default(global::VLB.RenderPipeline);
			}
			set
			{
			}
		}

		public global::VLB.RenderingMode renderingMode
		{
			get
			{
				return default(global::VLB.RenderingMode);
			}
			set
			{
			}
		}

		public bool SD_useSinglePassShader => false;

		public bool SD_requiresDoubleSidedMesh => false;

		public global::UnityEngine.Transform fadeOutCameraTransform => null;

		public int defaultRaymarchingQualityUniqueID => 0;

		public int raymarchingQualitiesCount => 0;

		public bool isHDRPExposureWeightSupported => false;

		public bool hasRenderPipelineMismatch => false;

		public static global::VLB.Config Instance => null;

		public bool IsSRPBatcherSupported()
		{
			return false;
		}

		public global::VLB.RenderingMode GetActualRenderingMode(global::VLB.ShaderMode shaderMode)
		{
			return default(global::VLB.RenderingMode);
		}

		public global::UnityEngine.Shader GetBeamShader(global::VLB.ShaderMode mode)
		{
			return null;
		}

		private ref global::UnityEngine.Shader GetBeamShaderInternal(global::VLB.ShaderMode mode)
		{
			throw null;
		}

		private int GetRenderQueueInternal(global::VLB.ShaderMode mode)
		{
			return 0;
		}

		public global::UnityEngine.Material NewMaterialTransient(global::VLB.ShaderMode mode, bool gpuInstanced)
		{
			return null;
		}

		public void SetURPScriptableRendererIndexToDepthCamera(global::UnityEngine.Camera camera)
		{
		}

		public void ForceUpdateFadeOutCamera()
		{
		}

		public global::VLB.RaymarchingQuality GetRaymarchingQualityForIndex(int index)
		{
			return null;
		}

		public global::VLB.RaymarchingQuality GetRaymarchingQualityForUniqueID(int id)
		{
			return null;
		}

		public int GetRaymarchingQualityIndexForUniqueID(int id)
		{
			return 0;
		}

		public bool IsRaymarchingQualityUniqueIDValid(int id)
		{
			return false;
		}

		private void CreateDefaultRaymarchingQualityPreset(bool onlyIfNeeded)
		{
		}

		[global::UnityEngine.RuntimeInitializeOnLoadMethod]
		private static void OnStartup()
		{
		}

		public void Reset()
		{
		}

		private void RefreshGlobalShaderProperties()
		{
		}

		public void ResetInternalData()
		{
		}

		public global::UnityEngine.ParticleSystem NewVolumetricDustParticles()
		{
			return null;
		}

		private void OnEnable()
		{
		}

		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}

		private static global::VLB.Config LoadAssetInternal(string assetName)
		{
			return null;
		}

		private static global::VLB.Config GetInstance(bool assertIfNotFound)
		{
			return null;
		}
	}
}
