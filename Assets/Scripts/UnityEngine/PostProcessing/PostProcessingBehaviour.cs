namespace UnityEngine.PostProcessing
{
	[global::UnityEngine.ImageEffectAllowedInSceneView]
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Camera))]
	[global::UnityEngine.DisallowMultipleComponent]
	[global::UnityEngine.ExecuteInEditMode]
	[global::UnityEngine.AddComponentMenu("Effects/Post-Processing Behaviour", -1)]
	public class PostProcessingBehaviour : global::UnityEngine.MonoBehaviour
	{
		public global::UnityEngine.PostProcessing.PostProcessingProfile profile;

		public global::System.Func<global::UnityEngine.Vector2, global::UnityEngine.Matrix4x4> jitteredMatrixFunc;

		private global::System.Collections.Generic.Dictionary<global::System.Type, global::System.Collections.Generic.KeyValuePair<global::UnityEngine.Rendering.CameraEvent, global::UnityEngine.Rendering.CommandBuffer>> m_CommandBuffers;

		private global::System.Collections.Generic.List<global::UnityEngine.PostProcessing.PostProcessingComponentBase> m_Components;

		private global::System.Collections.Generic.Dictionary<global::UnityEngine.PostProcessing.PostProcessingComponentBase, bool> m_ComponentStates;

		private global::UnityEngine.PostProcessing.MaterialFactory m_MaterialFactory;

		private global::UnityEngine.PostProcessing.RenderTextureFactory m_RenderTextureFactory;

		private global::UnityEngine.PostProcessing.PostProcessingContext m_Context;

		private global::UnityEngine.Camera m_Camera;

		private global::UnityEngine.PostProcessing.PostProcessingProfile m_PreviousProfile;

		private bool m_RenderingInSceneView;

		private global::UnityEngine.PostProcessing.BuiltinDebugViewsComponent m_DebugViews;

		private global::UnityEngine.PostProcessing.AmbientOcclusionComponent m_AmbientOcclusion;

		private global::UnityEngine.PostProcessing.ScreenSpaceReflectionComponent m_ScreenSpaceReflection;

		private global::UnityEngine.PostProcessing.FogComponent m_FogComponent;

		private global::UnityEngine.PostProcessing.MotionBlurComponent m_MotionBlur;

		private global::UnityEngine.PostProcessing.TaaComponent m_Taa;

		private global::UnityEngine.PostProcessing.EyeAdaptationComponent m_EyeAdaptation;

		private global::UnityEngine.PostProcessing.DepthOfFieldComponent m_DepthOfField;

		private global::UnityEngine.PostProcessing.BloomComponent m_Bloom;

		private global::UnityEngine.PostProcessing.ChromaticAberrationComponent m_ChromaticAberration;

		private global::UnityEngine.PostProcessing.ColorGradingComponent m_ColorGrading;

		private global::UnityEngine.PostProcessing.UserLutComponent m_UserLut;

		private global::UnityEngine.PostProcessing.GrainComponent m_Grain;

		private global::UnityEngine.PostProcessing.VignetteComponent m_Vignette;

		private global::UnityEngine.PostProcessing.DitheringComponent m_Dithering;

		private global::UnityEngine.PostProcessing.FxaaComponent m_Fxaa;

		private global::System.Collections.Generic.List<global::UnityEngine.PostProcessing.PostProcessingComponentBase> m_ComponentsToEnable;

		private global::System.Collections.Generic.List<global::UnityEngine.PostProcessing.PostProcessingComponentBase> m_ComponentsToDisable;

		private void OnEnable()
		{
		}

		private void OnPreCull()
		{
		}

		private void OnPreRender()
		{
		}

		private void OnPostRender()
		{
		}

		private void OnRenderImage(global::UnityEngine.RenderTexture source, global::UnityEngine.RenderTexture destination)
		{
		}

		private void OnGUI()
		{
		}

		private void OnDisable()
		{
		}

		public void ResetTemporalEffects()
		{
		}

		private void CheckObservers()
		{
		}

		private void DisableComponents()
		{
		}

		private global::UnityEngine.Rendering.CommandBuffer AddCommandBuffer<T>(global::UnityEngine.Rendering.CameraEvent evt, string name) where T : global::UnityEngine.PostProcessing.PostProcessingModel
		{
			return null;
		}

		private void RemoveCommandBuffer<T>() where T : global::UnityEngine.PostProcessing.PostProcessingModel
		{
		}

		private global::UnityEngine.Rendering.CommandBuffer GetCommandBuffer<T>(global::UnityEngine.Rendering.CameraEvent evt, string name) where T : global::UnityEngine.PostProcessing.PostProcessingModel
		{
			return null;
		}

		private void TryExecuteCommandBuffer<T>(global::UnityEngine.PostProcessing.PostProcessingComponentCommandBuffer<T> component) where T : global::UnityEngine.PostProcessing.PostProcessingModel
		{
		}

		private bool TryPrepareUberImageEffect<T>(global::UnityEngine.PostProcessing.PostProcessingComponentRenderTexture<T> component, global::UnityEngine.Material material) where T : global::UnityEngine.PostProcessing.PostProcessingModel
		{
			return false;
		}

		private T AddComponent<T>(T component) where T : global::UnityEngine.PostProcessing.PostProcessingComponentBase
		{
			return null;
		}
	}
}
