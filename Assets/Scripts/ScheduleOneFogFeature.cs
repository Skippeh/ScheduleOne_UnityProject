public class ScheduleOneFogFeature : global::UnityEngine.Rendering.Universal.ScriptableRendererFeature
{
	[global::System.Serializable]
	public class Settings
	{
		public global::UnityEngine.Rendering.Universal.RenderPassEvent RenderPassEvent;

		public global::UnityEngine.Shader Shader;

		public global::UnityEngine.Color Color;

		[global::UnityEngine.Range(0f, 100f)]
		public float Start;

		[global::UnityEngine.Range(0f, 5000f)]
		public float End;

		[global::UnityEngine.Range(0f, 1f)]
		public float Density;

		[global::UnityEngine.Range(0f, 10f)]
		public float BlurStrength;

		public float StartHeightFade;

		public float EndHeightFade;
	}

	public ScheduleOneFogFeature.Settings _settings;

	private ScheduleOneFogPass _pass;

	private global::UnityEngine.Material _material;

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
