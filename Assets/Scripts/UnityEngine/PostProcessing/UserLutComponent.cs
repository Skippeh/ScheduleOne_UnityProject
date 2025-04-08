namespace UnityEngine.PostProcessing
{
	public sealed class UserLutComponent : global::UnityEngine.PostProcessing.PostProcessingComponentRenderTexture<global::UnityEngine.PostProcessing.UserLutModel>
	{
		private static class Uniforms
		{
			internal static readonly int _UserLut;

			internal static readonly int _UserLut_Params;
		}

		public override bool active => false;

		public override void Prepare(global::UnityEngine.Material uberMaterial)
		{
		}

		public void OnGUI()
		{
		}
	}
}
