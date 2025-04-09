using System;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Emotions
{
	[Serializable]
	public class AvatarEmotionPreset
	{
		public string PresetName;

		public Texture2D FaceTexture;

		public Eye.EyeLidConfiguration LeftEyeRestingState;

		public Eye.EyeLidConfiguration RightEyeRestingState;

		[Range(-30f, 30f)]
		public float BrowAngleChange_L;

		[Range(-30f, 30f)]
		public float BrowAngleChange_R;

		[Range(-1f, 1f)]
		public float BrowHeightChange_L;

		[Range(-1f, 1f)]
		public float BrowHeightChange_R;

		public static AvatarEmotionPreset Lerp(AvatarEmotionPreset start, AvatarEmotionPreset end, AvatarEmotionPreset neutralPreset, float lerp)
		{
			return null;
		}
	}
}
