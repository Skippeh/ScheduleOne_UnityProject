public class FrameTimingsHUDDisplay : global::UnityEngine.MonoBehaviour
{
	public struct FrameTimingPoint
	{
		public double cpuFrameTime;

		public double cpuMainThreadFrameTime;

		public double cpuRenderThreadFrameTime;

		public double gpuFrameTime;
	}

	private global::UnityEngine.GUIStyle m_Style;

	private readonly global::UnityEngine.FrameTiming[] m_FrameTimings;

	public const int SAMPLE_SIZE = 200;

	public global::System.Collections.Generic.List<FrameTimingsHUDDisplay.FrameTimingPoint> frameTimingsHistory;

	private void Awake()
	{
	}

	private void OnGUI()
	{
	}

	private void CaptureTimings()
	{
	}
}
