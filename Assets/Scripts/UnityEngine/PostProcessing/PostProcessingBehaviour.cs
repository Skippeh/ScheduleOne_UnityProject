using System;
using System.Collections.Generic;
using UnityEngine.Rendering;

namespace UnityEngine.PostProcessing
{
	[ImageEffectAllowedInSceneView]
	[RequireComponent(typeof(Camera))]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[AddComponentMenu("Effects/Post-Processing Behaviour", -1)]
	public class PostProcessingBehaviour : MonoBehaviour
	{
		public PostProcessingProfile profile;

		public Func<Vector2, Matrix4x4> jitteredMatrixFunc;

		private Dictionary<Type, KeyValuePair<CameraEvent, CommandBuffer>> m_CommandBuffers;

		private List<PostProcessingComponentBase> m_Components;

		private Dictionary<PostProcessingComponentBase, bool> m_ComponentStates;

		private MaterialFactory m_MaterialFactory;

		private RenderTextureFactory m_RenderTextureFactory;

		private PostProcessingContext m_Context;

		private Camera m_Camera;

		private PostProcessingProfile m_PreviousProfile;

		private bool m_RenderingInSceneView;

		private BuiltinDebugViewsComponent m_DebugViews;

		private AmbientOcclusionComponent m_AmbientOcclusion;

		private ScreenSpaceReflectionComponent m_ScreenSpaceReflection;

		private FogComponent m_FogComponent;

		private MotionBlurComponent m_MotionBlur;

		private TaaComponent m_Taa;

		private EyeAdaptationComponent m_EyeAdaptation;

		private DepthOfFieldComponent m_DepthOfField;

		private BloomComponent m_Bloom;

		private ChromaticAberrationComponent m_ChromaticAberration;

		private ColorGradingComponent m_ColorGrading;

		private UserLutComponent m_UserLut;

		private GrainComponent m_Grain;

		private VignetteComponent m_Vignette;

		private DitheringComponent m_Dithering;

		private FxaaComponent m_Fxaa;

		private List<PostProcessingComponentBase> m_ComponentsToEnable;

		private List<PostProcessingComponentBase> m_ComponentsToDisable;

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

		private void OnRenderImage(RenderTexture source, RenderTexture destination)
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

		private CommandBuffer AddCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
		{
			return null;
		}

		private void RemoveCommandBuffer<T>() where T : PostProcessingModel
		{
		}

		private CommandBuffer GetCommandBuffer<T>(CameraEvent evt, string name) where T : PostProcessingModel
		{
			return null;
		}

		private void TryExecuteCommandBuffer<T>(PostProcessingComponentCommandBuffer<T> component) where T : PostProcessingModel
		{
		}

		private bool TryPrepareUberImageEffect<T>(PostProcessingComponentRenderTexture<T> component, Material material) where T : PostProcessingModel
		{
			return false;
		}

		private T AddComponent<T>(T component) where T : PostProcessingComponentBase
		{
			return null;
		}
	}
}
