using UnityEngine;

namespace VLB
{
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-depthbuffer/")]
	public class DynamicOcclusionDepthBuffer : DynamicOcclusionAbstractBase
	{
		public new const string ClassName = "DynamicOcclusionDepthBuffer";

		public LayerMask layerMask;

		public bool useOcclusionCulling;

		public int depthMapResolution;

		public float fadeDistanceToSurface;

		private Camera m_DepthCamera;

		private bool m_NeedToUpdateOcclusionNextFrame;

		protected override string GetShaderKeyword()
		{
			return null;
		}

		protected override MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(MaterialManager.SD.DynamicOcclusion);
		}

		private void ProcessOcclusionInternal()
		{
		}

		protected override bool OnProcessOcclusion(ProcessOcclusionSource source)
		{
			return false;
		}

		private void Update()
		{
		}

		private void UpdateDepthCameraPropertiesAccordingToBeam()
		{
		}

		public bool HasLayerMaskIssues()
		{
			return false;
		}

		protected override void OnValidateProperties()
		{
		}

		private void InstantiateOrActivateDepthCamera()
		{
		}

		protected override void OnEnablePostValidate()
		{
		}

		protected override void OnDisable()
		{
		}

		protected override void Awake()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void DestroyDepthCamera()
		{
		}

		protected override void OnModifyMaterialCallback(MaterialModifier.Interface owner)
		{
		}
	}
}
