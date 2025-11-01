namespace ScheduleOne.AvatarFramework.Emotions
{
	public class AvatarEmotionManager : global::UnityEngine.MonoBehaviour
	{
		public const float MAX_UPDATE_DISTANCE = 30f;

		[global::UnityEngine.Header("Settings")]
		public global::System.Collections.Generic.List<global::ScheduleOne.AvatarFramework.Emotions.AvatarEmotionPreset> EmotionPresetList;

		[global::UnityEngine.Header("References")]
		public global::ScheduleOne.AvatarFramework.Avatar Avatar;

		public global::ScheduleOne.AvatarFramework.EyeController EyeController;

		public global::ScheduleOne.AvatarFramework.EyebrowController EyebrowController;

		private global::ScheduleOne.AvatarFramework.Emotions.EmotionOverride activeEmotionOverride;

		private global::System.Collections.Generic.List<global::ScheduleOne.AvatarFramework.Emotions.EmotionOverride> overrideStack;

		private global::ScheduleOne.AvatarFramework.Emotions.AvatarEmotionPreset neutralPreset;

		private global::UnityEngine.Coroutine emotionLerpRoutine;

		private global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Coroutine> emotionRemovalRoutines;

		private int tempIndex;

		public string CurrentEmotion { get; protected set; }

		public global::ScheduleOne.AvatarFramework.Emotions.AvatarEmotionPreset CurrentEmotionPreset { get; protected set; }

		public bool IsSwitchingEmotion => false;

		private void Start()
		{
		}

		public void UpdateEmotion()
		{
		}

		public void ConfigureNeutralFace(global::UnityEngine.Texture2D faceTex, float restingBrowHeight, float restingBrowAngle, global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration leftEyelidConfig, global::ScheduleOne.AvatarFramework.Eye.EyeLidConfiguration rightEyelidConfig)
		{
		}

		public virtual void AddEmotionOverride(string emotionName, string overrideLabel, float duration = 0f, int priority = 0)
		{
		}

		public void RemoveEmotionOverride(string label)
		{
		}

		public void ClearOverrides()
		{
		}

		private void ClearRemovalRoutine(string label)
		{
		}

		public global::ScheduleOne.AvatarFramework.Emotions.EmotionOverride GetHighestPriorityOverride()
		{
			return null;
		}

		private void LerpEmotion(global::ScheduleOne.AvatarFramework.Emotions.AvatarEmotionPreset preset, float animationTime = 0.2f)
		{
		}

		private void SetEmotion(global::ScheduleOne.AvatarFramework.Emotions.AvatarEmotionPreset preset)
		{
		}

		public bool HasEmotion(string emotion)
		{
			return false;
		}

		public global::ScheduleOne.AvatarFramework.Emotions.AvatarEmotionPreset GetEmotion(string emotion)
		{
			return null;
		}
	}
}
