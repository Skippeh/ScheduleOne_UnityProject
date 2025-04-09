using System.Collections.Generic;
using UnityEngine;

namespace ScheduleOne.AvatarFramework.Emotions
{
	public class AvatarEmotionManager : MonoBehaviour
	{
		public const float MAX_UPDATE_DISTANCE = 30f;

		[Header("Settings")]
		public List<AvatarEmotionPreset> EmotionPresetList;

		[Header("References")]
		public Avatar Avatar;

		public EyeController EyeController;

		public EyebrowController EyebrowController;

		private EmotionOverride activeEmotionOverride;

		private List<EmotionOverride> overrideStack;

		private AvatarEmotionPreset neutralPreset;

		private Coroutine emotionLerpRoutine;

		private Dictionary<string, Coroutine> emotionRemovalRoutines;

		private int tempIndex;

		public string CurrentEmotion { get; protected set; }

		public AvatarEmotionPreset CurrentEmotionPreset { get; protected set; }

		public bool IsSwitchingEmotion => false;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void UpdateEmotion()
		{
		}

		public void ConfigureNeutralFace(Texture2D faceTex, float restingBrowHeight, float restingBrowAngle, Eye.EyeLidConfiguration leftEyelidConfig, Eye.EyeLidConfiguration rightEyelidConfig)
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

		public EmotionOverride GetHighestPriorityOverride()
		{
			return null;
		}

		private void LerpEmotion(AvatarEmotionPreset preset, float animationTime = 0.2f)
		{
		}

		private void SetEmotion(AvatarEmotionPreset preset)
		{
		}

		public bool HasEmotion(string emotion)
		{
			return false;
		}

		public AvatarEmotionPreset GetEmotion(string emotion)
		{
			return null;
		}
	}
}
