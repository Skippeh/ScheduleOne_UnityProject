namespace VLB
{
	[global::UnityEngine.AddComponentMenu("")]
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.HelpURL("http://saladgamer.com/vlb-doc/comp-lightbeam-sd/")]
	public class BeamGeometrySD : global::VLB.BeamGeometryAbstractBase, global::VLB.MaterialModifier.Interface
	{
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class _003CCoUpdateFadeOut_003Ed__17 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public global::VLB.BeamGeometrySD _003C_003E4__this;

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
			public _003CCoUpdateFadeOut_003Ed__17(int _003C_003E1__state)
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

		private global::VLB.VolumetricLightBeamSD m_Master;

		private global::VLB.MeshType m_CurrentMeshType;

		private global::VLB.MaterialModifier.Callback m_MaterialModifierCallback;

		private global::UnityEngine.Coroutine m_CoFadeOut;

		private global::UnityEngine.Camera m_CurrentCameraRenderingSRP;

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

		protected override global::VLB.VolumetricLightBeamAbstractBase GetMaster()
		{
			return null;
		}

		private float ComputeFadeOutFactor(global::UnityEngine.Transform camTransform)
		{
			return 0f;
		}

		[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(global::VLB.BeamGeometrySD._003CCoUpdateFadeOut_003Ed__17))]
		private global::System.Collections.IEnumerator CoUpdateFadeOut()
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

		public void Initialize(global::VLB.VolumetricLightBeamSD master)
		{
		}

		public void RegenerateMesh(bool masterEnabled)
		{
		}

		private global::UnityEngine.Vector3 ComputeLocalMatrix()
		{
			return default(global::UnityEngine.Vector3);
		}

		private global::VLB.MaterialManager.StaticPropertiesSD ComputeMaterialStaticProperties()
		{
			return default(global::VLB.MaterialManager.StaticPropertiesSD);
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

		private void MaterialChangeStart()
		{
		}

		private void MaterialChangeStop()
		{
		}

		public void SetDynamicOcclusionCallback(string shaderKeyword, global::VLB.MaterialModifier.Callback cb)
		{
		}

		public void UpdateMaterialAndBounds()
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

		private void UpdateCameraRelatedProperties(global::UnityEngine.Camera cam)
		{
		}
	}
}
