namespace ScheduleOne.GameTime
{
	public class TutorialTimeController : global::UnityEngine.MonoBehaviour
	{
		[global::System.Serializable]
		public struct KeyFrame
		{
			public int Time;

			public float SpeedMultiplier;

			public string Note;
		}

		public global::UnityEngine.AnimationCurve TimeProgressionCurve;

		public global::ScheduleOne.GameTime.TutorialTimeController.KeyFrame[] KeyFrames;

		[global::UnityEngine.SerializeField]
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

		[global::EasyButtons.Button]
		public void IncrementKeyframe()
		{
		}

		public void Disable()
		{
		}
	}
}
