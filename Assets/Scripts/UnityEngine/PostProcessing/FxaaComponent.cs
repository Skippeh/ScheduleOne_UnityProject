namespace UnityEngine.PostProcessing
{
	public sealed class FxaaComponent : PostProcessingComponentRenderTexture<AntialiasingModel>
	{
		private static class Uniforms
		{
			internal static readonly int _QualitySettings;

			internal static readonly int _ConsoleSettings;
		}

		public override bool active => false;

		public void Render(RenderTexture source, RenderTexture destination)
		{
		}
	}
}
