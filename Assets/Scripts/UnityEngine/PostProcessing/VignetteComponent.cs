namespace UnityEngine.PostProcessing
{
	public sealed class VignetteComponent : PostProcessingComponentRenderTexture<VignetteModel>
	{
		private static class Uniforms
		{
			internal static readonly int _Vignette_Color;

			internal static readonly int _Vignette_Center;

			internal static readonly int _Vignette_Settings;

			internal static readonly int _Vignette_Mask;

			internal static readonly int _Vignette_Opacity;
		}

		public override bool active => false;

		public override void Prepare(Material uberMaterial)
		{
		}
	}
}
