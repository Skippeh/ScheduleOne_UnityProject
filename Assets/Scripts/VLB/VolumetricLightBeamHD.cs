namespace VLB
{
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.DisallowMultipleComponent]
	[global::UnityEngine.SelectionBase]
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-hd/")]
	public class VolumetricLightBeamHD : global::VLB.VolumetricLightBeamAbstractBase
	{
		public new const string ClassName = "VolumetricLightBeamHD";

		[global::UnityEngine.SerializeField]
		private bool m_ColorFromLight;

		[global::UnityEngine.SerializeField]
		private global::VLB.ColorMode m_ColorMode;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Color m_ColorFlat;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Gradient m_ColorGradient;

		[global::UnityEngine.SerializeField]
		private global::VLB.BlendingMode m_BlendingMode;

		[global::UnityEngine.SerializeField]
		private float m_Intensity;

		[global::UnityEngine.SerializeField]
		private float m_IntensityMultiplier;

		[global::UnityEngine.SerializeField]
		private float m_HDRPExposureWeight;

		[global::UnityEngine.SerializeField]
		private float m_SpotAngle;

		[global::UnityEngine.SerializeField]
		private float m_SpotAngleMultiplier;

		[global::UnityEngine.SerializeField]
		private float m_ConeRadiusStart;

		[global::UnityEngine.SerializeField]
		private bool m_Scalable;

		[global::UnityEngine.SerializeField]
		private float m_FallOffStart;

		[global::UnityEngine.SerializeField]
		private float m_FallOffEnd;

		[global::UnityEngine.SerializeField]
		private float m_FallOffEndMultiplier;

		[global::UnityEngine.SerializeField]
		private global::VLB.AttenuationEquationHD m_AttenuationEquation;

		[global::UnityEngine.SerializeField]
		private float m_SideSoftness;

		[global::UnityEngine.SerializeField]
		private int m_RaymarchingQualityID;

		[global::UnityEngine.SerializeField]
		private float m_JitteringFactor;

		[global::UnityEngine.SerializeField]
		private int m_JitteringFrameRate;

		[global::VLB.MinMaxRange(0f, 1f)]
		[global::UnityEngine.SerializeField]
		private global::VLB.MinMaxRangeFloat m_JitteringLerpRange;

		[global::UnityEngine.SerializeField]
		private global::VLB.NoiseMode m_NoiseMode;

		[global::UnityEngine.SerializeField]
		private float m_NoiseIntensity;

		[global::UnityEngine.SerializeField]
		private bool m_NoiseScaleUseGlobal;

		[global::UnityEngine.SerializeField]
		private float m_NoiseScaleLocal;

		[global::UnityEngine.SerializeField]
		private bool m_NoiseVelocityUseGlobal;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.Vector3 m_NoiseVelocityLocal;

		protected global::VLB.BeamGeometryHD m_BeamGeom;

		public bool colorFromLight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::VLB.ColorMode colorMode
		{
			get
			{
				return default(global::VLB.ColorMode);
			}
			set
			{
			}
		}

		public global::UnityEngine.Color colorFlat
		{
			get
			{
				return default(global::UnityEngine.Color);
			}
			set
			{
			}
		}

		public global::UnityEngine.Gradient colorGradient
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private bool useColorFromAttachedLightSpot => false;

		private bool useColorTemperatureFromAttachedLightSpot => false;

		public float intensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float intensityMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useIntensityFromAttachedLightSpot => false;

		public float hdrpExposureWeight
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::VLB.BlendingMode blendingMode
		{
			get
			{
				return default(global::VLB.BlendingMode);
			}
			set
			{
			}
		}

		public float spotAngle
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float spotAngleMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useSpotAngleFromAttachedLightSpot => false;

		public float coneAngle => 0f;

		public float coneRadiusStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float coneRadiusEnd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float coneVolume => 0f;

		public bool scalable
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::VLB.AttenuationEquationHD attenuationEquation
		{
			get
			{
				return default(global::VLB.AttenuationEquationHD);
			}
			set
			{
			}
		}

		public float fallOffStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fallOffEnd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float maxGeometryDistance => 0f;

		public float fallOffEndMultiplier
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool useFallOffEndFromAttachedLightSpot => false;

		public float sideSoftness
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float jitteringFactor
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public int jitteringFrameRate
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public global::VLB.MinMaxRangeFloat jitteringLerpRange
		{
			get
			{
				return default(global::VLB.MinMaxRangeFloat);
			}
			set
			{
			}
		}

		public global::VLB.NoiseMode noiseMode
		{
			get
			{
				return default(global::VLB.NoiseMode);
			}
			set
			{
			}
		}

		public bool isNoiseEnabled => false;

		public float noiseIntensity
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool noiseScaleUseGlobal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float noiseScaleLocal
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool noiseVelocityUseGlobal
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector3 noiseVelocityLocal
		{
			get
			{
				return default(global::UnityEngine.Vector3);
			}
			set
			{
			}
		}

		public int raymarchingQualityID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int raymarchingQualityIndex
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int blendingModeAsInt => 0;

		public global::UnityEngine.Quaternion beamInternalLocalRotation => default(global::UnityEngine.Quaternion);

		public global::UnityEngine.Vector3 beamLocalForward => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 beamGlobalForward => default(global::UnityEngine.Vector3);

		public uint _INTERNAL_InstancedMaterialGroupID { get; protected set; }

		public float GetConeApexOffsetZ(bool counterApplyScaleForUnscalableBeam)
		{
			return 0f;
		}

		public override bool IsScalable()
		{
			return false;
		}

		public override global::VLB.BeamGeometryAbstractBase GetBeamGeometry()
		{
			return null;
		}

		protected override void SetBeamGeometryNull()
		{
		}

		public override global::UnityEngine.Vector3 GetLossyScale()
		{
			return default(global::UnityEngine.Vector3);
		}

		public global::VLB.VolumetricCookieHD GetAdditionalComponentCookie()
		{
			return null;
		}

		public global::VLB.VolumetricShadowHD GetAdditionalComponentShadow()
		{
			return null;
		}

		public void SetPropertyDirty(global::VLB.DirtyProps flags)
		{
		}

		public virtual global::VLB.Dimensions GetDimensions()
		{
			return default(global::VLB.Dimensions);
		}

		public virtual bool DoesSupportSorting2D()
		{
			return false;
		}

		public virtual int GetSortingLayerID()
		{
			return 0;
		}

		public virtual int GetSortingOrder()
		{
			return 0;
		}

		public float GetInsideBeamFactor(global::UnityEngine.Vector3 posWS)
		{
			return 0f;
		}

		public float GetInsideBeamFactorFromObjectSpacePos(global::UnityEngine.Vector3 posOS)
		{
			return 0f;
		}

		public virtual void GenerateGeometry()
		{
		}

		public virtual void UpdateAfterManualPropertyChange()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDidApplyAnimationProperties()
		{
		}

		public void AssignPropertiesFromAttachedSpotLight()
		{
		}

		private void ClampProperties()
		{
		}

		private void ValidateProperties()
		{
		}

		private void HandleBackwardCompatibility(int serializedVersion, int newVersion)
		{
		}
	}
}
