public class ScheduleOneFogPass : global::UnityEngine.Rendering.Universal.ScriptableRenderPass
{
	private global::UnityEngine.Material _material;

	private global::UnityEngine.Rendering.RTHandle _cameraColorTarget;

	private global::UnityEngine.Rendering.RTHandle _tempTexture;

	private global::UnityEngine.Color _color;

	private float _start;

	private float _end;

	private float _density;

	private float _blurStrength;

	private float _startHeightFade;

	private float _endHeightFade;

	public ScheduleOneFogPass(global::UnityEngine.Material material)
	{
	}

	public void Setup(ScheduleOneFogFeature.Settings settings, global::UnityEngine.Rendering.RTHandle cameraColorTarget)
	{
	}

	public override void OnCameraSetup(global::UnityEngine.Rendering.CommandBuffer cmd, ref global::UnityEngine.Rendering.Universal.RenderingData renderingData)
	{
	}

	public override void Execute(global::UnityEngine.Rendering.ScriptableRenderContext context, ref global::UnityEngine.Rendering.Universal.RenderingData renderingData)
	{
	}

	public void Dispose()
	{
	}
}
