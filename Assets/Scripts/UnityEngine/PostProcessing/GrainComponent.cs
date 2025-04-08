namespace UnityEngine.PostProcessing
{
	public sealed class GrainComponent : global::UnityEngine.PostProcessing.PostProcessingComponentRenderTexture<global::UnityEngine.PostProcessing.GrainModel>
	{
		private static class Uniforms
		{
			internal static readonly int _Grain_Params1;

			internal static readonly int _Grain_Params2;

			internal static readonly int _GrainTex;

			internal static readonly int _Phase;
		}

		private global::UnityEngine.RenderTexture m_GrainLookupRT;

		public override bool active => false;

		public override void OnDisable()
		{
		}

		public override void Prepare(global::UnityEngine.Material uberMaterial)
		{
		}
	}
}
