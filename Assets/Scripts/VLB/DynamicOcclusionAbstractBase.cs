namespace VLB
{
	[global::UnityEngine.AddComponentMenu("")]
	[global::UnityEngine.DisallowMultipleComponent]
	[global::UnityEngine.RequireComponent(typeof(global::VLB.VolumetricLightBeamSD))]
	public abstract class DynamicOcclusionAbstractBase : global::UnityEngine.MonoBehaviour
	{
		protected enum ProcessOcclusionSource
		{
			RenderLoop = 0,
			OnEnable = 1,
			EditorUpdate = 2,
			User = 3
		}

		public const string ClassName = "DynamicOcclusionAbstractBase";

		public global::VLB.DynamicOcclusionUpdateRate updateRate;

		[global::UnityEngine.Serialization.FormerlySerializedAs("waitFrameCount")]
		public int waitXFrames;

		public static bool _INTERNAL_ApplyRandomFrameOffset;

		private global::VLB.TransformUtils.Packed m_TransformPacked;

		private int m_LastFrameRendered;

		protected global::VLB.VolumetricLightBeamSD m_Master;

		protected global::VLB.MaterialModifier.Callback m_MaterialModifierCallbackCached;

		public int _INTERNAL_LastFrameRendered => 0;

		public event global::System.Action onOcclusionProcessed
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

		public void ProcessOcclusionManually()
		{
		}

		protected void ProcessOcclusion(global::VLB.DynamicOcclusionAbstractBase.ProcessOcclusionSource source)
		{
		}

		protected abstract string GetShaderKeyword();

		protected abstract global::VLB.MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode();

		protected abstract bool OnProcessOcclusion(global::VLB.DynamicOcclusionAbstractBase.ProcessOcclusionSource source);

		protected abstract void OnModifyMaterialCallback(global::VLB.MaterialModifier.Interface owner);

		protected abstract void OnEnablePostValidate();

		protected virtual void OnValidateProperties()
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnEnable()
		{
		}

		protected virtual void OnDisable()
		{
		}

		private void OnWillCameraRender(global::UnityEngine.Camera cam)
		{
		}

		private void DisableOcclusion()
		{
		}
	}
}
