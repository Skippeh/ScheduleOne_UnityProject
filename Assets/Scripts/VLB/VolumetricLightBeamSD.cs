namespace VLB
{
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.DisallowMultipleComponent]
	[global::UnityEngine.SelectionBase]
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-sd/")]
	public class VolumetricLightBeamSD : global::VLB.VolumetricLightBeamAbstractBase
	{
		public delegate void OnWillCameraRenderCB(global::UnityEngine.Camera cam);

		public delegate void OnBeamGeometryInitialized();

		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CCoPlaytimeUpdate_003Ed__199 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::VLB.VolumetricLightBeamSD _003C_003E4__this;

			object global::System.Collections.Generic.IEnumerator<object>.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			object global::System.Collections.IEnumerator.Current
			{
				[global::System.Diagnostics.DebuggerHidden]
				get
				{
					return null;
				}
			}

			[global::System.Diagnostics.DebuggerHidden]
			public _003CCoPlaytimeUpdate_003Ed__199(int _003C_003E1__state)
			{
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool global::System.Collections.IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[global::System.Diagnostics.DebuggerHidden]
			void global::System.Collections.IEnumerator.Reset()
			{
			}
		}

		public new const string ClassName = "VolumetricLightBeamSD";

		public bool colorFromLight;

		public global::VLB.ColorMode colorMode;

		[global::UnityEngine.ColorUsage(false, true)]
		[global::UnityEngine.Serialization.FormerlySerializedAs("colorValue")]
		public global::UnityEngine.Color color;

		public global::UnityEngine.Gradient colorGradient;

		public bool intensityFromLight;

		public bool intensityModeAdvanced;

		[global::UnityEngine.Serialization.FormerlySerializedAs("alphaInside")]
		[global::UnityEngine.Min(0f)]
		public float intensityInside;

		[global::UnityEngine.Serialization.FormerlySerializedAs("alphaOutside")]
		[global::UnityEngine.Serialization.FormerlySerializedAs("alpha")]
		[global::UnityEngine.Min(0f)]
		public float intensityOutside;

		[global::UnityEngine.Min(0f)]
		public float intensityMultiplier;

		[global::UnityEngine.Range(0f, 1f)]
		public float hdrpExposureWeight;

		public global::VLB.BlendingMode blendingMode;

		[global::UnityEngine.Serialization.FormerlySerializedAs("angleFromLight")]
		public bool spotAngleFromLight;

		[global::UnityEngine.Range(0.1f, 179.9f)]
		public float spotAngle;

		[global::UnityEngine.Min(0f)]
		public float spotAngleMultiplier;

		[global::UnityEngine.Serialization.FormerlySerializedAs("radiusStart")]
		public float coneRadiusStart;

		public global::VLB.ShaderAccuracy shaderAccuracy;

		public global::VLB.MeshType geomMeshType;

		[global::UnityEngine.Serialization.FormerlySerializedAs("geomSides")]
		public int geomCustomSides;

		public int geomCustomSegments;

		public global::UnityEngine.Vector3 skewingLocalForwardDirection;

		public global::UnityEngine.Transform clippingPlaneTransform;

		public bool geomCap;

		public global::VLB.AttenuationEquation attenuationEquation;

		[global::UnityEngine.Range(0f, 1f)]
		public float attenuationCustomBlending;

		[global::UnityEngine.Serialization.FormerlySerializedAs("fadeStart")]
		public float fallOffStart;

		[global::UnityEngine.Serialization.FormerlySerializedAs("fadeEnd")]
		public float fallOffEnd;

		[global::UnityEngine.Serialization.FormerlySerializedAs("fadeEndFromLight")]
		public bool fallOffEndFromLight;

		[global::UnityEngine.Min(0f)]
		public float fallOffEndMultiplier;

		public float depthBlendDistance;

		public float cameraClippingDistance;

		[global::UnityEngine.Range(0f, 1f)]
		public float glareFrontal;

		[global::UnityEngine.Range(0f, 1f)]
		public float glareBehind;

		[global::UnityEngine.Serialization.FormerlySerializedAs("fresnelPowOutside")]
		public float fresnelPow;

		public global::VLB.NoiseMode noiseMode;

		[global::UnityEngine.Range(0f, 1f)]
		public float noiseIntensity;

		public bool noiseScaleUseGlobal;

		[global::UnityEngine.Range(0.01f, 2f)]
		public float noiseScaleLocal;

		public bool noiseVelocityUseGlobal;

		public global::UnityEngine.Vector3 noiseVelocityLocal;

		public global::VLB.Dimensions dimensions;

		public global::UnityEngine.Vector2 tiltFactor;

		private global::VLB.MaterialManager.SD.DynamicOcclusion m_INTERNAL_DynamicOcclusionMode;

		private bool m_INTERNAL_DynamicOcclusionMode_Runtime;

		private global::VLB.VolumetricLightBeamSD.OnBeamGeometryInitialized m_OnBeamGeometryInitialized;

		[global::UnityEngine.Serialization.FormerlySerializedAs("trackChangesDuringPlaytime")]
		[global::UnityEngine.SerializeField]
		private bool _TrackChangesDuringPlaytime;

		[global::UnityEngine.SerializeField]
		private int _SortingLayerID;

		[global::UnityEngine.SerializeField]
		private int _SortingOrder;

		[global::UnityEngine.Serialization.FormerlySerializedAs("fadeOutBegin")]
		[global::UnityEngine.SerializeField]
		private float _FadeOutBegin;

		[global::UnityEngine.Serialization.FormerlySerializedAs("fadeOutEnd")]
		[global::UnityEngine.SerializeField]
		private float _FadeOutEnd;

		private global::VLB.BeamGeometrySD m_BeamGeom;

		private global::UnityEngine.Coroutine m_CoPlaytimeUpdate;

		public global::VLB.ColorMode usedColorMode => default(global::VLB.ColorMode);

		private bool useColorFromAttachedLightSpot => false;

		private bool useColorTemperatureFromAttachedLightSpot => false;

		[global::System.Obsolete("Use 'intensityGlobal' or 'intensityInside' instead")]
		public float alphaInside
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[global::System.Obsolete("Use 'intensityGlobal' or 'intensityOutside' instead")]
		public float alphaOutside
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float intensityGlobal
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

		public bool useSpotAngleFromAttachedLightSpot => false;

		public float coneAngle => 0f;

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

		public float coneApexOffsetZ => 0f;

		public global::UnityEngine.Vector3 coneApexPositionLocal => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 coneApexPositionGlobal => default(global::UnityEngine.Vector3);

		public int geomSides
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int geomSegments
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public global::UnityEngine.Vector3 skewingLocalForwardDirectionNormalized => default(global::UnityEngine.Vector3);

		public bool canHaveMeshSkewing => false;

		public bool hasMeshSkewing => false;

		public global::UnityEngine.Vector4 additionalClippingPlane => default(global::UnityEngine.Vector4);

		public float attenuationLerpLinearQuad => 0f;

		[global::System.Obsolete("Use 'fallOffStart' instead")]
		public float fadeStart
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[global::System.Obsolete("Use 'fallOffEnd' instead")]
		public float fadeEnd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[global::System.Obsolete("Use 'fallOffEndFromLight' instead")]
		public bool fadeEndFromLight
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool useFallOffEndFromAttachedLightSpot => false;

		public float maxGeometryDistance => 0f;

		public bool isNoiseEnabled => false;

		[global::System.Obsolete("Use 'noiseMode' instead")]
		public bool noiseEnabled
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public float fadeOutBegin
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float fadeOutEnd
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public bool isFadeOutEnabled => false;

		public bool isTilted => false;

		public int sortingLayerID
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string sortingLayerName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int sortingOrder
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool trackChangesDuringPlaytime
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool isCurrentlyTrackingChanges => false;

		public int blendingModeAsInt => 0;

		public global::UnityEngine.Quaternion beamInternalLocalRotation => default(global::UnityEngine.Quaternion);

		public global::UnityEngine.Vector3 beamLocalForward => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 beamGlobalForward => default(global::UnityEngine.Vector3);

		public float raycastDistance => 0f;

		public global::UnityEngine.Vector3 raycastGlobalForward => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 raycastGlobalUp => default(global::UnityEngine.Vector3);

		public global::UnityEngine.Vector3 raycastGlobalRight => default(global::UnityEngine.Vector3);

		public global::VLB.MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode
		{
			get
			{
				return default(global::VLB.MaterialManager.SD.DynamicOcclusion);
			}
			set
			{
			}
		}

		public global::VLB.MaterialManager.SD.DynamicOcclusion _INTERNAL_DynamicOcclusionMode_Runtime => default(global::VLB.MaterialManager.SD.DynamicOcclusion);

		public uint _INTERNAL_InstancedMaterialGroupID { get; protected set; }

		public string meshStats => null;

		public int meshVerticesCount => 0;

		public int meshTrianglesCount => 0;

		public event global::VLB.VolumetricLightBeamSD.OnWillCameraRenderCB onWillCameraRenderThisBeam
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			add
			{
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			remove
			{
			}
		}

		public void GetInsideAndOutsideIntensity(out float inside, out float outside)
		{
			inside = default(float);
			outside = default(float);
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

		private global::UnityEngine.Vector3 ComputeRaycastGlobalVector(global::UnityEngine.Vector3 localVec)
		{
			return default(global::UnityEngine.Vector3);
		}

		public void _INTERNAL_SetDynamicOcclusionCallback(string shaderKeyword, global::VLB.MaterialModifier.Callback cb)
		{
		}

		public void _INTERNAL_OnWillCameraRenderThisBeam(global::UnityEngine.Camera cam)
		{
		}

		public void RegisterOnBeamGeometryInitializedCallback(global::VLB.VolumetricLightBeamSD.OnBeamGeometryInitialized cb)
		{
		}

		private void CallOnBeamGeometryInitializedCallback()
		{
		}

		private void SetFadeOutValue(ref float propToChange, float value)
		{
		}

		private void OnFadeOutStateChanged()
		{
		}

		public float GetInsideBeamFactor(global::UnityEngine.Vector3 posWS)
		{
			return 0f;
		}

		public float GetInsideBeamFactorFromObjectSpacePos(global::UnityEngine.Vector3 posOS)
		{
			return 0f;
		}

		[global::System.Obsolete("Use 'GenerateGeometry()' instead")]
		public void Generate()
		{
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

		private void StartPlaytimeUpdateIfNeeded()
		{
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::VLB.VolumetricLightBeamSD._003CCoPlaytimeUpdate_003Ed__199))]
		private global::System.Collections.IEnumerator CoPlaytimeUpdate()
		{
			return null;
		}

		private void AssignPropertiesFromAttachedSpotLight()
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
