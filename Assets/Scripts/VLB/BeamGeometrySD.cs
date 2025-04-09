using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-sd/")]
	public class BeamGeometrySD : BeamGeometryAbstractBase, MaterialModifier.Interface
	{
		[CompilerGenerated]
		private sealed class _003CCoUpdateFadeOut_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BeamGeometrySD _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCoUpdateFadeOut_003Ed__17(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		private VolumetricLightBeamSD m_Master;

		private MeshType m_CurrentMeshType;

		private MaterialModifier.Callback m_MaterialModifierCallback;

		private Coroutine m_CoFadeOut;

		private Camera m_CurrentCameraRenderingSRP;

		private bool visible
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

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

		public bool _INTERNAL_IsFadeOutCoroutineRunning => false;

		public static bool isCustomRenderPipelineSupported => false;

		private bool shouldUseGPUInstancedMaterial => false;

		private bool isNoiseEnabled => false;

		private bool isDepthBlendEnabled => false;

		protected override VolumetricLightBeamAbstractBase GetMaster()
		{
			return null;
		}

		private float ComputeFadeOutFactor(Transform camTransform)
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003CCoUpdateFadeOut_003Ed__17))]
		private IEnumerator CoUpdateFadeOut()
		{
			return null;
		}

		private void ComputeFadeOutFactor()
		{
		}

		private void SetFadeOutFactorProp(float value)
		{
		}

		private void StopFadeOutCoroutine()
		{
		}

		public void RestartFadeOutCoroutine()
		{
		}

		public void OnMasterEnable()
		{
		}

		public void OnMasterDisable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnEnable()
		{
		}

		public void Initialize(VolumetricLightBeamSD master)
		{
		}

		public void RegenerateMesh(bool masterEnabled)
		{
		}

		private Vector3 ComputeLocalMatrix()
		{
			return default(Vector3);
		}

		private MaterialManager.StaticPropertiesSD ComputeMaterialStaticProperties()
		{
			return default(MaterialManager.StaticPropertiesSD);
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

		private void MaterialChangeStart()
		{
		}

		private void MaterialChangeStop()
		{
		}

		public void SetDynamicOcclusionCallback(string shaderKeyword, MaterialModifier.Callback cb)
		{
		}

		public void UpdateMaterialAndBounds()
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

		private void UpdateCameraRelatedProperties(Camera cam)
		{
		}
	}
}
