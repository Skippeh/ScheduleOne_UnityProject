namespace UnityEngine.PostProcessing
{
	public sealed class ChromaticAberrationComponent : global::UnityEngine.PostProcessing.PostProcessingComponentRenderTexture<global::UnityEngine.PostProcessing.ChromaticAberrationModel>
	{
		private static class Uniforms
		{
			internal static readonly int _ChromaticAberration_Amount;

			internal static readonly int _ChromaticAberration_Spectrum;
		}

		private global::UnityEngine.Texture2D m_SpectrumLut;

		public override bool active => false;

		public override void OnDisable()
		{
		}

		public override void Prepare(global::UnityEngine.Material uberMaterial)
		{
		}
	}
}
