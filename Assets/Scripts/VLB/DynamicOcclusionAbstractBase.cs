using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace VLB
{
	[AddComponentMenu("")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(VolumetricLightBeamSD))]
	public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
	{
		protected enum ProcessOcclusionSource
		{
			RenderLoop = 0,
			OnEnable = 1,
			EditorUpdate = 2,
			User = 3
		}

		public const string ClassName = "DynamicOcclusionAbstractBase";

		public DynamicOcclusionUpdateRate updateRate;

		[FormerlySerializedAs("waitFrameCount")]
		public int waitXFrames;

		public static bool _INTERNAL_ApplyRandomFrameOffset;

		private TransformUtils.Packed m_TransformPacked;

		private int m_LastFrameRendered;

		protected VolumetricLightBeamSD m_Master;

		protected MaterialModifier.Callback m_MaterialModifierCallbackCached;

		public int _INTERNAL_LastFrameRendered => 0;

		public event Action onOcclusionProcessed
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void ProcessOcclusionManually()
		{
		}

		protected void ProcessOcclusion(ProcessOcclusionSource source)
		{
		}

		protected abstract string GetShaderKeyword();

		protected abstract MaterialManager.SD.DynamicOcclusion GetDynamicOcclusionMode();

		protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

		protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

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

		private void OnWillCameraRender(Camera cam)
		{
		}

		private void DisableOcclusion()
		{
		}
	}
}
