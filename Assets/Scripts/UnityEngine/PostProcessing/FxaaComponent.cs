namespace UnityEngine.PostProcessing
{
	public sealed class FxaaComponent : global::UnityEngine.PostProcessing.PostProcessingComponentRenderTexture<global::UnityEngine.PostProcessing.AntialiasingModel>
	{
		private static class Uniforms
		{
			internal static readonly int _QualitySettings;

			internal static readonly int _ConsoleSettings;
		}

		public override bool active => false;

		public void Render(global::UnityEngine.RenderTexture source, global::UnityEngine.RenderTexture destination)
		{
		}
	}
}
