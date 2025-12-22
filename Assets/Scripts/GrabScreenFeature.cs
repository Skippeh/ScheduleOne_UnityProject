public class GrabScreenFeature : global::UnityEngine.Rendering.Universal.ScriptableRendererFeature
{
	[global::System.Serializable]
	public class Settings
	{
		public string TextureName;

		public global::UnityEngine.LayerMask LayerMask;
	}

	public class GrabPass : global::UnityEngine.Rendering.Universal.ScriptableRenderPass
	{
		private GrabScreenFeature.Settings settings;

		private global::UnityEngine.Rendering.RTHandle m_GrabbedTextureHandle;

		private global::UnityEngine.Rendering.RTHandle m_CameraColorHandle;

		public GrabPass(GrabScreenFeature.Settings s)
		{
		}

		public override void OnCameraSetup(global::UnityEngine.Rendering.CommandBuffer cmd, ref global::UnityEngine.Rendering.Universal.RenderingData renderingData)
		{
		}

		public override void Execute(global::UnityEngine.Rendering.ScriptableRenderContext context, ref global::UnityEngine.Rendering.Universal.RenderingData renderingData)
		{
		}

		public void Dispose()
		{
		}
	}

	private class RenderPass : global::UnityEngine.Rendering.Universal.ScriptableRenderPass
	{
		private GrabScreenFeature.Settings settings;

		private global::System.Collections.Generic.List<global::UnityEngine.Rendering.ShaderTagId> m_ShaderTagIdList;

		private global::UnityEngine.Rendering.FilteringSettings m_FilteringSettings;

		private global::UnityEngine.Rendering.RenderStateBlock m_RenderStateBlock;

		public RenderPass(GrabScreenFeature.Settings settings)
		{
		}

		public override void Execute(global::UnityEngine.Rendering.ScriptableRenderContext context, ref global::UnityEngine.Rendering.Universal.RenderingData renderingData)
		{
		}
	}

	private GrabScreenFeature.GrabPass grabPass;

	private GrabScreenFeature.RenderPass renderPass;

	[global::UnityEngine.SerializeField]
	private GrabScreenFeature.Settings settings;

	public override void Create()
	{
	}

	public override void AddRenderPasses(global::UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref global::UnityEngine.Rendering.Universal.RenderingData renderingData)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
