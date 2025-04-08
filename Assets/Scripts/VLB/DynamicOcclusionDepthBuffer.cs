namespace VLB
{
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-dynocclusion-sd-depthbuffer/")]
	public class DynamicOcclusionDepthBuffer : global::VLB.DynamicOcclusionAbstractBase
	{
		public new const string ClassName = "DynamicOcclusionDepthBuffer";

		public global::UnityEngine.LayerMask layerMask;

		public bool useOcclusionCulling;

		public int depthMapResolution;

		public float fadeDistanceToSurface;

		private global::UnityEngine.Camera m_DepthCamera;

		private bool m_NeedToUpdateOcclusionNextFrame;

		protected override string GetShaderKeyword()
		{
			return null;
		}

		protected override global::VLB.MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode()
		{
			return default(global::VLB.MaterialManager.SD.DynamicOcclusion);
		}

		private void ProcessOcclusionInternal()
		{
		}

		protected override bool OnProcessOcclusion(global::VLB.DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
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

		protected override void OnModifyMaterialCallback(global::VLB.MaterialModifier.Interface owner)
		{
		}
	}
}
