namespace ScheduleOne.UI
{
	public class EyelidOverlay : global::ScheduleOne.DevUtilities.Singleton<global::ScheduleOne.UI.EyelidOverlay>
	{
		public const float MaxTiredOpenAmount = 0.625f;

		public bool AutoUpdate;

		[global::UnityEngine.Header("Settings")]
		public float Open;

		public float Closed;

		[global::UnityEngine.Header("References")]
		public global::UnityEngine.RectTransform Upper;

		public global::UnityEngine.RectTransform Lower;

		public global::UnityEngine.Canvas Canvas;

		[global::UnityEngine.Range(0f, 1f)]
		public float CurrentOpen;

		public global::ScheduleOne.Tools.FloatSmoother OpenMultiplier;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		public void SetOpen(float openness)
		{
		}
	}
}
