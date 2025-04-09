namespace UnityEngine.PostProcessing
{
	public sealed class UserLutComponent : PostProcessingComponentRenderTexture<UserLutModel>
	{
		private static class Uniforms
		{
			internal static readonly int _UserLut;

			internal static readonly int _UserLut_Params;
		}

		public override bool active => false;

		public override void Prepare(Material uberMaterial)
		{
		}

		public void OnGUI()
		{
		}
	}
}
