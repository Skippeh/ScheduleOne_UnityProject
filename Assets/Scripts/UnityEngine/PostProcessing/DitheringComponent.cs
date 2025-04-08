namespace UnityEngine.PostProcessing
{
	public sealed class DitheringComponent : global::UnityEngine.PostProcessing.PostProcessingComponentRenderTexture<global::UnityEngine.PostProcessing.DitheringModel>
	{
		private static class Uniforms
		{
			internal static readonly int _DitheringTex;

			internal static readonly int _DitheringCoords;
		}

		private global::UnityEngine.Texture2D[] noiseTextures;

		private int textureIndex;

		private const int k_TextureCount = 64;

		public override bool active => false;

		public override void OnDisable()
		{
		}

		private void LoadNoiseTextures()
		{
		}

		public override void Prepare(global::UnityEngine.Material uberMaterial)
		{
		}
	}
}
