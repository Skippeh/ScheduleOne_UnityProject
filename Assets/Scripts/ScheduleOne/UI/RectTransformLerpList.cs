namespace ScheduleOne.UI
{
	public class RectTransformLerpList : global::ScheduleOne.UI.RectTransformLerp
	{
		[global::UnityEngine.SerializeField]
		private global::UnityEngine.RectTransform[] _targetPositions;

		[global::UnityEngine.SerializeField]
		private bool _scaleDurationWithDistance;

		[global::UnityEngine.SerializeField]
		private bool _lerpLocalPosition;

		[global::UnityEngine.SerializeField]
		private bool _lerpScale;

		private float _longestDistance;

		protected override void Awake()
		{
		}

		public void LerpTo(int index, float duration)
		{
		}

		public void LerpTo(int index)
		{
		}

		private float GetDurationMultiplier(global::UnityEngine.Vector2 start, global::UnityEngine.Vector2 end)
		{
			return 0f;
		}
	}
}
