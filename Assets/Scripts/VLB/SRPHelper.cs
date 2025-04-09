using System;
using UnityEngine;
using UnityEngine.Rendering;

namespace VLB
{
	public static class SRPHelper
	{
		private static bool m_IsRenderPipelineCached;

		private static RenderPipeline m_RenderPipelineCached;

		public static string renderPipelineScriptingDefineSymbolAsString => null;

		public static RenderPipeline projectRenderPipeline => default(RenderPipeline);

		private static RenderPipeline ComputeRenderPipeline()
		{
			return default(RenderPipeline);
		}

		public static bool IsUsingCustomRenderPipeline()
		{
			return false;
		}

		public static void RegisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}

		public static void UnregisterOnBeginCameraRendering(Action<ScriptableRenderContext, Camera> cb)
		{
		}
	}
}
