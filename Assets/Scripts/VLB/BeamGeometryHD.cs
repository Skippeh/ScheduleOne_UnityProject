using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-hd/")]
	public class BeamGeometryHD : BeamGeometryAbstractBase
	{
		public enum InvalidTexture
		{
			Null = 0,
			NoDepth = 1
		}

		private VolumetricLightBeamHD m_Master;

		private VolumetricCookieHD m_Cookie;

		private VolumetricShadowHD m_Shadow;

		private Camera m_CurrentCameraRenderingSRP;

		private DirtyProps m_DirtyProps;

		public bool visible
		{
			set
			{
			}
		}

		public int sortingLayerID
		{
			set
			{
			}
		}

		public int sortingOrder
		{
			set
			{
			}
		}

		public static bool isCustomRenderPipelineSupported => false;

		private bool shouldUseGPUInstancedMaterial => false;

		private bool isNoiseEnabled => false;

		protected override VolumetricLightBeamAbstractBase GetMaster()
		{
			return null;
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		public void Initialize(VolumetricLightBeamHD master)
		{
		}

		public void RegenerateMesh()
		{
		}

		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		private MaterialManager.StaticPropertiesHD ComputeMaterialStaticProperties()
		{
			return default(MaterialManager.StaticPropertiesHD);
		}

		private bool ApplyMaterial()
		{
			return false;
		}

		public void SetMaterialProp(int nameID, float value)
		{
		}

		public void SetMaterialProp(int nameID, Vector4 value)
		{
		}

		public void SetMaterialProp(int nameID, Color value)
		{
		}

		public void SetMaterialProp(int nameID, Matrix4x4 value)
		{
		}

		public void SetMaterialProp(int nameID, Texture value)
		{
		}

		public void SetMaterialProp(int nameID, InvalidTexture invalidTexture)
		{
		}

		private void MaterialChangeStart()
		{
		}

		private void MaterialChangeStop()
		{
		}

		public void SetPropertyDirty(DirtyProps prop)
		{
		}

		private void UpdateMaterialAndBounds()
		{
		}

		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		private void OnBeginCameraRenderingSRP(ScriptableRenderContext context, Camera cam)
		{
		}

		private void OnWillRenderObject()
		{
		}

		private void OnWillCameraRenderThisBeam(Camera cam)
		{
		}

		private void UpdateDirtyMaterialProperties()
		{
		}

		private void UpdateMaterialPropertiesForCamera(Camera cam)
		{
		}
	}
}
