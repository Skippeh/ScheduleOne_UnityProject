using System;
using EasyButtons;
using UnityEngine;

namespace ScheduleOne.GameTime
{
	public class TutorialTimeController : MonoBehaviour
	{
		[Serializable]
		public struct KeyFrame
		{
			public int Time;

			public float SpeedMultiplier;

			public string Note;
		}

		public AnimationCurve TimeProgressionCurve;

		public KeyFrame[] KeyFrames;

		[SerializeField]
		private int currentKeyFrameIndex;

		private bool disabled;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private int GetCurrentKeyFrameStart()
		{
			return 0;
		}

		[Button]
		public void IncrementKeyframe()
		{
		}

		public void Disable()
		{
		}
	}
}
