public class VFXRainPass : global::UnityEngine.Rendering.Universal.ScriptableRenderPass
{
	private global::UnityEngine.Rendering.RTHandle _cameraColorTarget;

	private global::UnityEngine.Rendering.RTHandle _cameraDepthTarget;

	private global::UnityEngine.LayerMask _layerMask;

	private global::UnityEngine.Rendering.FilteringSettings _filteringSettings;

	private static readonly global::UnityEngine.Rendering.ShaderTagId[] _shaderTagIds;

	public void Setup(VFXRainFeature.Settings settings, global::UnityEngine.Rendering.RTHandle cameraColorTarget, global::UnityEngine.Rendering.RTHandle cameraDepthTarget)
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
