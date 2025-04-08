namespace ScheduleOne.AvatarFramework.Emotions
{
	[global::System.Serializable]
	public class AvatarEmotionPreset
	{
		public string PresetName;

		public global::UnityEngine.Texture2D FaceTexture;

		public global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration LeftEyeRestingState;

		public global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration RightEyeRestingState;

		[global::UnityEngine.Range(-30f, 30f)]
		public float BrowAngleChange_L;

		[global::UnityEngine.Range(-30f, 30f)]
		public float BrowAngleChange_R;

		[global::UnityEngine.Range(-1f, 1f)]
		public float BrowHeightChange_L;

		[global::UnityEngine.Range(-1f, 1f)]
		public float BrowHeightChange_R;

		public static global::ScheduleOne.AvatarFramework.Emotions.AvatarEmotionPreset Lerp(global::ScheduleOne.AvatarFramework.Emotions.AvatarEmotionPreset start, global::ScheduleOne.AvatarFramework.Emotions.AvatarEmotionPreset end, global::ScheduleOne.AvatarFramework.Emotions.AvatarEmotionPreset neutralPreset, float lerp)
		{
			return null;
		}
	}
}
