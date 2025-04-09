using UnityEngine;

namespace VLB
{
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeamHD))]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-shadow-hd/")]
	public class VolumetricShadowHD : MonoBehaviour
	{
		private enum ProcessOcclusionSource
		{
			RenderLoop = 0,
			OnEnable = 1,
			EditorUpdate = 2,
			User = 3
		}

		public const string ClassName = "VolumetricShadowHD";

		[SerializeField]
		private float m_Strength;

		[SerializeField]
		private ShadowUpdateRate m_UpdateRate;

		[SerializeField]
		private int m_WaitXFrames;

		[SerializeField]
		private LayerMask m_LayerMask;

		[SerializeField]
		private bool m_UseOcclusionCulling;

		[SerializeField]
		private int m_DepthMapResolution;

		private VolumetricLightBeamHD m_Master;

		private TransformUtils.Packed m_TransformPacked;

		private int m_LastFrameRendered;

		private Camera m_DepthCamera;

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

		public ShadowUpdateRate updateRate
		{
			get
			{
				return default(ShadowUpdateRate);
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

		public LayerMask layerMask
		{
			get
			{
				return default(LayerMask);
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

		private void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		public static void ApplyMaterialProperties(VolumetricShadowHD instance, BeamGeometryHD geom)
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

		public void OnWillCameraRenderThisBeam(Camera cam, BeamGeometryHD beamGeom)
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
