namespace VLB
{
	public static class SRPHelper
	{
		private static bool m_IsRenderPipelineCached;

		private static global::VLB.RenderPipeline m_RenderPipelineCached;

		public static string renderPipelineScriptingDefineSymbolAsString => null;

		public static global::VLB.RenderPipeline projectRenderPipeline => default(global::VLB.RenderPipeline);

		private static global::VLB.RenderPipeline ComputeRenderPipeline()
		{
			return default(global::VLB.RenderPipeline);
		}

		public static bool IsUsingCustomRenderPipeline()
		{
			return false;
		}

		public static void RegisterOnBeginCameraRendering(global::System.Action<global::UnityEngine.Rendering.ScriptableRenderContext, global::UnityEngine.Camera> cb)
		{
		}

		public static void UnregisterOnBeginCameraRendering(global::System.Action<global::UnityEngine.Rendering.ScriptableRenderContext, global::UnityEngine.Camera> cb)
		{
		}
	}
}
