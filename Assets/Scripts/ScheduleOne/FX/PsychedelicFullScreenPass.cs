namespace ScheduleOne.FX
{
	public class PsychedelicFullScreenPass : global::UnityEngine.Rendering.Universal.ScriptableRenderPass
	{
		private global::ScheduleOne.FX.PsychedelicFullScreenFeature.Settings _settings;

		private global::UnityEngine.Rendering.RTHandle _source;

		private global::UnityEngine.Rendering.RTHandle _tempTexture;

		private global::UnityEngine.Material _material;

		private static readonly int BLEND_ID;

		private static readonly int NOISE_SCALE_ID;

		private static readonly int PAN_SPEED_ID;

		private static readonly int DOES_BOUNCE_ID;

		private static readonly int AMPLITUDE_ID;

		public PsychedelicFullScreenPass(global::ScheduleOne.FX.PsychedelicFullScreenFeature.Settings settings)
		{
		}

		public override void OnCameraSetup(global::UnityEngine.Rendering.CommandBuffer cmd, ref global::UnityEngine.Rendering.Universal.RenderingData renderingData)
		{
		}

		public override void Execute(global::UnityEngine.Rendering.ScriptableRenderContext context, ref global::UnityEngine.Rendering.Universal.RenderingData renderingData)
		{
		}

		public override void OnCameraCleanup(global::UnityEngine.Rendering.CommandBuffer cmd)
		{
		}
	}
}
