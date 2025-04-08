namespace VLB
{
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.DisallowMultipleComponent]
	[global::UnityEngine.RequireComponent(typeof(global::VLB.VolumetricLightBeamHD))]
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-shadow-hd/")]
	public class VolumetricShadowHD : global::UnityEngine.MonoBehaviour
	{
		private enum ProcessOcclusionSource
		{
			RenderLoop = 0,
			OnEnable = 1,
			EditorUpdate = 2,
			User = 3
		}

		public const string ClassName = "VolumetricShadowHD";

		[global::UnityEngine.SerializeField]
		private float m_Strength;

		[global::UnityEngine.SerializeField]
		private global::VLB.ShadowUpdateRate m_UpdateRate;

		[global::UnityEngine.SerializeField]
		private int m_WaitXFrames;

		[global::UnityEngine.SerializeField]
		private global::UnityEngine.LayerMask m_LayerMask;

		[global::UnityEngine.SerializeField]
		private bool m_UseOcclusionCulling;

		[global::UnityEngine.SerializeField]
		private int m_DepthMapResolution;

		private global::VLB.VolumetricLightBeamHD m_Master;

		private global::VLB.TransformUtils.Packed m_TransformPacked;

		private int m_LastFrameRendered;

		private global::UnityEngine.Camera m_DepthCamera;

		private bool m_NeedToUpdateOcclusionNextFrame;

		public static bool _INTERNAL_ApplyRandomFrameOffset;

		public float strength
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public global::VLB.ShadowUpdateRate updateRate
		{
			get
			{
				return default(global::VLB.ShadowUpdateRate);
			}
			set
			{
			}
		}

		public int waitXFrames
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public global::UnityEngine.LayerMask layerMask
		{
			get
			{
				return default(global::UnityEngine.LayerMask);
			}
			set
			{
			}
		}

		public bool useOcclusionCulling
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public int depthMapResolution
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int _INTERNAL_LastFrameRendered => 0;

		public void ProcessOcclusionManually()
		{
		}

		public void UpdateDepthCameraProperties()
		{
		}

		private void ProcessOcclusion(global::VLB.VolumetricShadowHD.ProcessOcclusionSource source)
		{
		}

		public static void ApplyMaterialProperties(global::VLB.VolumetricShadowHD instance, global::VLB.BeamGeometryHD geom)
		{
		}

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void ProcessOcclusionInternal()
		{
		}

		private void OnBeamEnabled()
		{
		}

		public void OnWillCameraRenderThisBeam(global::UnityEngine.Camera cam, global::VLB.BeamGeometryHD beamGeom)
		{
		}

		private void Update()
		{
		}

		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		private void InstantiateOrActivateDepthCamera()
		{
		}

		private void DestroyDepthCamera()
		{
		}

		private void OnValidateProperties()
		{
		}

		private void SetDirty()
		{
		}
	}
}
