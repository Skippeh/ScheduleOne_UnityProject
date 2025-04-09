using System;
using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.DevUtilities
{
	[Serializable]
	public struct DisplaySettings
	{
		public enum EDisplayMode
		{
			Windowed = 0,
			FullscreenWindow = 1,
			ExclusiveFullscreen = 2
		}

		public int ResolutionIndex;

		public EDisplayMode DisplayMode;

		public bool VSync;

		public int TargetFPS;

		public float UIScale;

		public float CameraBobbing;

		public int ActiveDisplayIndex;

		public static List<Resolution> GetResolutions()
		{
			return null;
		}
	}
}
