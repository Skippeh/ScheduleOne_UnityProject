namespace VLB
{
	[global::UnityEngine.AddComponentMenu("")]
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-hd/")]
	public class BeamGeometryHD : global::VLB.BeamGeometryAbstractBase
	{
		public enum InvalidTexture
		{
			Null = 0,
			NoDepth = 1
		}

		private global::VLB.VolumetricLightBeamHD m_Master;

		private global::VLB.VolumetricCookieHD m_Cookie;

		private global::VLB.VolumetricShadowHD m_Shadow;

		private global::UnityEngine.Camera m_CurrentCameraRenderingSRP;

		private global::VLB.DirtyProps m_DirtyProps;

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

		protected override global::VLB.VolumetricLightBeamAbstractBase GetMaster()
		{
			return null;
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		public void Initialize(global::VLB.VolumetricLightBeamHD master)
		{
		}

		public void RegenerateMesh()
		{
		}

		private global::UnityEngine.Vector3 ComputeLocalMatrix()
		{
			return default(global::UnityEngine.Vector3);
		}

		private global::VLB.MaterialManager.StaticPropertiesHD ComputeMaterialStaticProperties()
		{
			return default(global::VLB.MaterialManager.StaticPropertiesHD);
		}

		private bool ApplyMaterial()
		{
			return false;
		}

		public void SetMaterialProp(int nameID, float value)
		{
		}

		public void SetMaterialProp(int nameID, global::UnityEngine.Vector4 value)
		{
		}

		public void SetMaterialProp(int nameID, global::UnityEngine.Color value)
		{
		}

		public void SetMaterialProp(int nameID, global::UnityEngine.Matrix4x4 value)
		{
		}

		public void SetMaterialProp(int nameID, global::UnityEngine.Texture value)
		{
		}

		public void SetMaterialProp(int nameID, global::VLB.BeamGeometryHD.InvalidTexture invalidTexture)
		{
		}

		private void MaterialChangeStart()
		{
		}

		private void MaterialChangeStop()
		{
		}

		public void SetPropertyDirty(global::VLB.DirtyProps prop)
		{
		}

		private void UpdateMaterialAndBounds()
		{
		}

		private void UpdateMatricesPropertiesForGPUInstancingSRP()
		{
		}

		private void OnBeginCameraRenderingSRP(global::UnityEngine.Rendering.ScriptableRenderContext context, global::UnityEngine.Camera cam)
		{
		}

		private void OnWillRenderObject()
		{
		}

		private void OnWillCameraRenderThisBeam(global::UnityEngine.Camera cam)
		{
		}

		private void UpdateDirtyMaterialProperties()
		{
		}

		private void UpdateMaterialPropertiesForCamera(global::UnityEngine.Camera cam)
		{
		}
	}
}
