using System.Collections.Generic;
using UnityEngine;

public class FrameTimingsHUDDisplay : MonoBehaviour
{
	public struct FrameTimingPoint
	{
		public double cpuFrameTime;

		public double cpuMainThreadFrameTime;

		public double cpuRenderThreadFrameTime;

		public double gpuFrameTime;
	}

	private GUIStyle m_Style;

	private readonly FrameTiming[] m_FrameTimings;

	public const int SAMPLE_SIZE = 200;

	public List<FrameTimingPoint> frameTimingsHistory;

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
