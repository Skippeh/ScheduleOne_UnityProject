using UnityEngine;

namespace VLB
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[SelectionBase]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-hd/")]
	public class VolumetricLightBeamHD : VolumetricLightBeamAbstractBase
	{
		public new const string ClassName = "VolumetricLightBeamHD";

		[SerializeField]
		private bool m_ColorFromLight;

		[SerializeField]
		private ColorMode m_ColorMode;

		[SerializeField]
		private Color m_ColorFlat;

		[SerializeField]
		private Gradient m_ColorGradient;

		[SerializeField]
		private BlendingMode m_BlendingMode;

		[SerializeField]
		private float m_Intensity;

		[SerializeField]
		private float m_IntensityMultiplier;

		[SerializeField]
		private float m_HDRPExposureWeight;

		[SerializeField]
		private float m_SpotAngle;

		[SerializeField]
		private float m_SpotAngleMultiplier;

		[SerializeField]
		private float m_ConeRadiusStart;

		[SerializeField]
		private bool m_Scalable;

		[SerializeField]
		private float m_FallOffStart;

		[SerializeField]
		private float m_FallOffEnd;

		[SerializeField]
		private float m_FallOffEndMultiplier;

		[SerializeField]
		private AttenuationEquationHD m_AttenuationEquation;

		[SerializeField]
		private float m_SideSoftness;

		[SerializeField]
		private int m_RaymarchingQualityID;

		[SerializeField]
		private float m_JitteringFactor;

		[SerializeField]
		private int m_JitteringFrameRate;

		[MinMaxRange(0f, 1f)]
		[SerializeField]
		private MinMaxRangeFloat m_JitteringLerpRange;

		[SerializeField]
		private NoiseMode m_NoiseMode;

		[SerializeField]
		private float m_NoiseIntensity;

		[SerializeField]
		private bool m_NoiseScaleUseGlobal;

		[SerializeField]
		private float m_NoiseScaleLocal;

		[SerializeField]
		private bool m_NoiseVelocityUseGlobal;

		[SerializeField]
		private Vector3 m_NoiseVelocityLocal;

		protected BeamGeometryHD m_BeamGeom;

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

		public ColorMode colorMode
		{
			get
			{
				return default(ColorMode);
			}
			set
			{
			}
		}

		public Color colorFlat
		{
			get
			{
				return default(Color);
			}
			set
			{
			}
		}

		public Gradient colorGradient
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

		public BlendingMode blendingMode
		{
			get
			{
				return default(BlendingMode);
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

		public AttenuationEquationHD attenuationEquation
		{
			get
			{
				return default(AttenuationEquationHD);
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

		public MinMaxRangeFloat jitteringLerpRange
		{
			get
			{
				return default(MinMaxRangeFloat);
			}
			set
			{
			}
		}

		public NoiseMode noiseMode
		{
			get
			{
				return default(NoiseMode);
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

		public Vector3 noiseVelocityLocal
		{
			get
			{
				return default(Vector3);
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

		public Quaternion beamInternalLocalRotation => default(Quaternion);

		public Vector3 beamLocalForward => default(Vector3);

		public Vector3 beamGlobalForward => default(Vector3);

		public uint _INTERNAL_InstancedMaterialGroupID { get; protected set; }

		public float GetConeApexOffsetZ(bool counterApplyScaleForUnscalableBeam)
		{
			return 0f;
		}

		public override bool IsScalable()
		{
			return false;
		}

		public override BeamGeometryAbstractBase GetBeamGeometry()
		{
			return null;
		}

		protected override void SetBeamGeometryNull()
		{
		}

		public override Vector3 GetLossyScale()
		{
			return default(Vector3);
		}

		public VolumetricCookieHD GetAdditionalComponentCookie()
		{
			return null;
		}

		public VolumetricShadowHD GetAdditionalComponentShadow()
		{
			return null;
		}

		public void SetPropertyDirty(DirtyProps flags)
		{
		}

		public virtual Dimensions GetDimensions()
		{
			return default(Dimensions);
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

		public float GetInsideBeamFactor(Vector3 posWS)
		{
			return 0f;
		}

		public float GetInsideBeamFactorFromObjectSpacePos(Vector3 posOS)
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
