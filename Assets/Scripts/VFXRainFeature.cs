public class VFXRainFeature : global::UnityEngine.Rendering.Universal.ScriptableRendererFeature
{
	[global::System.Serializable]
	public class Settings
	{
		public global::UnityEngine.Rendering.Universal.RenderPassEvent RenderPassEvent;

		public global::UnityEngine.LayerMask LayerMask;
	}

	public VFXRainFeature.Settings _settings;

	private VFXRainPass _pass;

	public override void Create()
	{
	}

	public override void SetupRenderPasses(global::UnityEngine.Rendering.Universal.ScriptableRenderer renderer, in global::UnityEngine.Rendering.Universal.RenderingData renderingData)
	{
	}

	public override void AddRenderPasses(global::UnityEngine.Rendering.Universal.ScriptableRenderer renderer, ref global::UnityEngine.Rendering.Universal.RenderingData renderingData)
	{
	}

	protected override void Dispose(bool disposing)
	{
	}
}
